using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace Membership_Check {
    public partial class Form1 : Form {

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
                Application.Exit();
            } else {
                SqlConnection membersDatabase = Database.connect();

                if (membersDatabase != null) {
                    if (checkMemberText.Text.Length > 0) {
                        DateTime today = DateTime.Now;
                        string studentNumber = formatStudentNumber(checkMemberText.Text);
                        bool hasPaid = Database.paid(studentNumber, membersDatabase);

                        if (hasPaid) {
                            Database.attend(studentNumber, today, membersDatabase);
                            checkMemberText.Text = "";
                            this.Hide();
                            Form logoutForm = new Form2();
                            logoutForm.Show();
                        } else {
                            DialogResult result = MessageBox.Show("Membership has not been paid. Would you like to use your free uses?", "Membership", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (result == DialogResult.Yes) {
                                Database.addUse(studentNumber, membersDatabase);
                                int? freeUses = Database.getUse(studentNumber, membersDatabase);

                                if (freeUses <= 2) {
                                    MessageBox.Show("Number of uses left: " + freeUses.ToString(), "Free Use", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Database.attend(studentNumber, today, membersDatabase);
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
                Database.disconnect(membersDatabase);
            }
        }
    }
}
