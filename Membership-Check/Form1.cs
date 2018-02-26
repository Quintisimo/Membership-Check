using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace Membership_Check {
    public partial class Form1 : Form {
        bool connected;

        public Form1() {
            InitializeComponent();
            placeControls();
        }

        /// <summary>
        /// Prevents closing form with ALT+F4
        /// </summary>
        private void Form1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e) {
            if (e.Alt && e.KeyCode == Keys.F4) {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Places all the form elements dynamically
        /// </summary>
        private void placeControls() {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

            esportsLogo.Location = new Point(
                this.ClientSize.Width/2 - esportsLogo.Size.Width/2,
                this.ClientSize.Height/2 - esportsLogo.Size.Height/2
            );

            checkMemberLabel.Location = new Point(
                this.ClientSize.Width / 2 - checkMemberLabel.Size.Width / 2,
                this.ClientSize.Height - 100
            );

            checkMemberText.Location = new Point(
                this.ClientSize.Width / 2 - checkMemberText.Size.Width / 2,
                this.ClientSize.Height - 50
            );

            checkMemberButton.Location = new Point(
                this.ClientSize.Width/2 - checkMemberButton.Size.Width/2,
                this.ClientSize.Height + 10
            );
        }

        /// <summary>
        /// Tries to connect to the database and if it cant throws an error
        /// </summary>
        /// <returns>database</returns>
        private SqlConnection connectDatabase() {
            SqlConnection membersDatabase = new SqlConnection("Data Source=qutesports.database.windows.net;Initial Catalog=qutesportsMembership;Persist Security Info=True;User ID=qutesports;Password=Lagswitch1");
            try {
                membersDatabase.Open();
                connected = true;
            } catch (Exception error) {
                MessageBox.Show(error.ToString(), "Connect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connected = false;
            }
            return membersDatabase;
        }

        /// <summary>
        /// Disconnects from currently conected database
        /// </summary>
        /// <param name="database">connected database</param>
        private void disconnectDatabase(SqlConnection database) {
            try {
                database.Close();
            } catch (Exception error) {
                MessageBox.Show(error.ToString(), "Disconnect", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Formats student number to a standard convention
        /// </summary>
        /// <param name="studentNumber">student number</param>
        /// <returns></returns>
        private string formatStudentNumber(string studentNumber) {
            studentNumber = Regex.Replace(studentNumber, "n", "", RegexOptions.IgnoreCase);

            if (studentNumber.Length == 7) {
                studentNumber = "0" + studentNumber;
            }

            if (studentNumber.Length > 8) {
                studentNumber = studentNumber.Substring(0, studentNumber.Length - 2);
            }

            if (studentNumber.Length == 8) {
                return studentNumber;
            } else {
                MessageBox.Show("Student Number not entered correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        /// <summary>
        /// Checks if a member is in the database
        /// </summary>
        private void checkMemberButton_Click(object sender, EventArgs e) {
            if (checkMemberText.Text == "Lagswitch1") {
                this.Close();
            } 

            SqlConnection membersDatabase = connectDatabase();

            if (connected) {
                if (checkMemberText.Text.Length > 0) {
                    DateTime today = DateTime.Now;
                    string studentNumber = formatStudentNumber(checkMemberText.Text);
                    SqlCommand paidStatus = new SqlCommand("SELECT Paid FROM Members WHERE StudentNumber = '" + studentNumber + "'", membersDatabase);
                    string hasPaid = Convert.ToString(paidStatus.ExecuteScalar());

                    if (hasPaid == "Yes") {
                        SqlCommand attendanceLog = new SqlCommand("INSERT INTO Attendance(StudentNumber, Time, Day, Month, Year) VALUES ('" + studentNumber + "','" + today.ToString("HH:mm") + "','" + today.ToString("dd") + "','" + today.ToString("MMMM") + "','" + today.Year + "')", membersDatabase);
                        attendanceLog.ExecuteNonQuery();
                        checkMemberText.Text = "";
                        this.Hide();
                        Form logoutForm = new Form2();
                        logoutForm.Show();
                    } else {
                        DialogResult result = MessageBox.Show("Membership has not been paid. Would you like to use your free uses?", "Membership", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes) {
                            try {
                                SqlCommand addMember = new SqlCommand("INSERT INTO Members(StudentNumber, Paid, FreeUse) VALUES ('" + studentNumber + "', 'No', 1)", membersDatabase);
                                addMember.ExecuteNonQuery();
                            } catch {
                                SqlCommand updateUse = new SqlCommand("UPDATE Members SET FreeUse = FreeUse + 1", membersDatabase);
                                updateUse.ExecuteNonQuery();
                            }

                            SqlCommand checkUses = new SqlCommand("SELECT FreeUse FROM Members WHERE StudentNumber ='" + studentNumber + "'", membersDatabase);
                            int freeUse = Convert.ToInt32(checkUses.ExecuteScalar());

                            if (freeUse == 1) {
                                MessageBox.Show("This is your first free use", "Free Use", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                SqlCommand attendanceLog = new SqlCommand("INSERT INTO Attendance(StudentNumber, Time, Day, Month, Year) VALUES ('" + studentNumber + "','" + today.ToString("HH:mm") + "','" + today.ToString("dd") + "','" + today.ToString("MMMM") + "','" + today.Year + "')", membersDatabase);
                                attendanceLog.ExecuteNonQuery();
                                checkMemberText.Text = "";
                                this.Hide();
                                Form logoutForm = new Form2();
                                logoutForm.Show();
                            } else if (freeUse == 2) {
                                MessageBox.Show("This is your last free use", "Free Use", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                SqlCommand attendanceLog = new SqlCommand("INSERT INTO Attendance(StudentNumber, Time, Day, Month, Year) VALUES ('" + studentNumber + "','" + today.ToString("HH:mm") + "','" + today.ToString("dd") + "','" + today.ToString("MMMM") + "','" + today.Year + "')", membersDatabase);
                                attendanceLog.ExecuteNonQuery();
                                checkMemberText.Text = "";
                                this.Hide();
                                Form logoutForm = new Form2();
                                logoutForm.Show();
                            } else {
                                MessageBox.Show("You do not have any free uses left", "Free Uses", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                    }
                } else {
                    MessageBox.Show("Please enter a student number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            disconnectDatabase(membersDatabase);
        }
    }
}
