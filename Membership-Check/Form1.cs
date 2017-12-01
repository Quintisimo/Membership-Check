using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QUT_eSports_Membership {
    public partial class Form1 : Form {
        bool connected;

        public Form1() {
            InitializeComponent();
        }

        private SqlConnection connectDatabase() {
            SqlConnection membersDatabase;
            membersDatabase = new SqlConnection("Data Source=qutesports.database.windows.net;Initial Catalog=qutesportsMembership;Persist Security Info=True;User ID=qutesports;Password=Lagswitch1");
            try {
                membersDatabase.Open();
                connected = true;
            } catch (Exception error) {
                MessageBox.Show(error.ToString(), "Connect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connected = false;
            }
            return membersDatabase;
        }

        private void disconnectDatabase(SqlConnection database) {
            try {
                database.Close();
            } catch (Exception error) {
                MessageBox.Show(error.ToString(), "Disconnect", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string formatStudentNumber(string studentNumber) {
            
            studentNumber = studentNumber.TrimEnd(studentNumber[studentNumber.Length - 2]);
            studentNumber = studentNumber.TrimStart(studentNumber[0]);
            
            if (studentNumber.Length == 7) {
                studentNumber = "0" + studentNumber;
            }
            return studentNumber;
        }

        private void generatedCSV(string query, string filename) {
            SqlConnection membersDatabase = connectDatabase();
            if (connected) {
                SqlCommand getUsers = new SqlCommand(query, membersDatabase);
                SqlDataReader readUsers = getUsers.ExecuteReader();
                using (System.IO.StreamWriter fs = new System.IO.StreamWriter(filename)) {
                    for (int i = 0; i < readUsers.FieldCount; i++) {
                        string name = readUsers.GetName(i);
                        if (name.Contains(","))
                            name = "\"" + name + "\"";

                        fs.Write(name + ",");
                    }
                    fs.WriteLine();

                    while (readUsers.Read()) {
                        for (int i = 0; i < readUsers.FieldCount; i++) {
                            string value = readUsers[i].ToString();
                            if (value.Contains(","))
                                value = "\"" + value + "\"";

                            fs.Write(value + ",");
                        }
                        fs.WriteLine();
                    }
                    fs.Close();
                }
            }
            disconnectDatabase(membersDatabase);
        }

        private void addMemberButton_Click(object sender, EventArgs e) {
            SqlConnection membersDatabase = connectDatabase();

            if (connected) {
                if (addMemberPasswordText.Text == "Lagswitch1") {
                    if (addMemberText.Text != null) {
                        string studentNumber = formatStudentNumber(addMemberText.Text);
                        try {
                            SqlCommand addMember = new SqlCommand("INSERT INTO Members(StudentNumber, Paid) VALUES ('" + studentNumber + "', 'Yes')", membersDatabase);
                            addMember.ExecuteNonQuery();
                            MessageBox.Show("Member has been added successfully", "Membership", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        } catch {
                            SqlCommand paidStatus = new SqlCommand("SELECT Paid FROM Members WHERE StudentNumber = '" + studentNumber + "'", membersDatabase);
                            string hasPaid = Convert.ToString(paidStatus.ExecuteScalar());

                            if (hasPaid == "No") {
                                SqlCommand paid = new SqlCommand("UPDATE Members SET Paid = 'Yes'", membersDatabase);
                                paid.ExecuteNonQuery();
                                MessageBox.Show("Member status has been updated", "Membership", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            } else {
                                MessageBox.Show("Member already exists", "Membership", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        addMemberText.Text = "";
                        addMemberPasswordText.Text = "";
                    } else {
                        MessageBox.Show("Please enter a student number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                } else {
                    MessageBox.Show("Please enter the correct password", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                disconnectDatabase(membersDatabase);
            }
        }

        private void checkMemberButton_Click(object sender, EventArgs e) {
            SqlConnection membersDatabase = connectDatabase();

            if (connected) {
                if (checkMemberText.Text != null) {
                    DateTime today = DateTime.Now;
                    string studentNumber = formatStudentNumber(checkMemberText.Text);
                    SqlCommand paidStatus = new SqlCommand("SELECT Paid FROM Members WHERE StudentNumber = '" + studentNumber + "'", membersDatabase);
                    string hasPaid = Convert.ToString(paidStatus.ExecuteScalar());

                    if (hasPaid == "Yes") {
                        MessageBox.Show("Membership has been paid", "Membership", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SqlCommand attendanceLog = new SqlCommand("INSERT INTO Attendance(StudentNumber, Time, Day, Month, Year) VALUES ('" + studentNumber + "','" + today.ToString("HH:mm") + "','" + today.ToString("dd") + "','" + today.ToString("MMMM") + "','" + today.Year + "')", membersDatabase);
                        attendanceLog.ExecuteNonQuery();
                        checkMemberText.Text = "";
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
                            } else if (freeUse == 2) {
                                MessageBox.Show("This is your last free use", "Free Use", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                SqlCommand attendanceLog = new SqlCommand("INSERT INTO Attendance(StudentNumber, Time, Day, Month, Year) VALUES ('" + studentNumber + "','" + today.ToString("HH:mm") + "','" + today.ToString("dd") + "','" + today.ToString("MMMM") + "','" + today.Year + "')", membersDatabase);
                                attendanceLog.ExecuteNonQuery();
                                checkMemberText.Text = "";
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

        private void getMemberButton_Click(object sender, EventArgs e) {
            if (getMembersPasswordText.Text == "Lagswitch1") {
                if (membersListRadio.Checked) {
                    generatedCSV("SELECT * FROM Members", "Members List.csv");
                    MessageBox.Show("Members list has been generated", "Members List", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getMembersPasswordText.Text = "";
                } else if (membersAttendanceRadio.Checked) {
                    generatedCSV("SELECT * FROM Attendance", "Members Attendance.csv");
                    MessageBox.Show("Members list has been generated", "Members Attendance", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getMembersPasswordText.Text = "";
                } else {
                    MessageBox.Show("Please select one option", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else {
                MessageBox.Show("Please enter the correct password", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
