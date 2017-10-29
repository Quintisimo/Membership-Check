using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QUT_eSports_Membership {
    public partial class Form1 : Form {
        SqlConnection membersDatabase;

        public Form1() {
            InitializeComponent();
            membersDatabase = new SqlConnection("Data Source=qutesports.database.windows.net;Initial Catalog=qutesportsMembership;Persist Security Info=True;User ID=qutesports;Password=Lagswitch1");
            try {
                membersDatabase.Open();
            } catch (Exception error) {
                MessageBox.Show(error.ToString(), "Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void addMemberButton_Click(object sender, EventArgs e) {
            if (addMemberText.Text != null) {
                string studentNumber = formatStudentNumber(addMemberText.Text);
                try {
                    SqlCommand addMember = new SqlCommand("INSERT INTO Members(StudentNumber, Paid) VALUES ('" + studentNumber + "', 'Yes')", membersDatabase);
                    addMember.ExecuteNonQuery();
                    MessageBox.Show("Member has been added successfully", "Membership", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } catch {
                    MessageBox.Show("Member already exists", "Membership", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                addMemberText.Text = "";
            } else {
                MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void checkMemberButton_Click(object sender, EventArgs e) {
            if (checkMemberText.Text != null) {
                DateTime today = DateTime.Now;
                string studentNumber = formatStudentNumber(checkMemberText.Text);
                SqlCommand paidStatus = new SqlCommand("SELECT Paid FROM MEMBERS WHERE StudentNumber = '" + studentNumber + "'", membersDatabase);
                string hasPaid = Convert.ToString(paidStatus.ExecuteScalar());

                if (hasPaid == "Yes") {
                    MessageBox.Show("Membership has been paid", "Membership", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        } else if (freeUse == 2) {
                            MessageBox.Show("This is your last free use", "Free Use", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        } else {
                            MessageBox.Show("You do not have any free uses left", "Free Uses", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }

                }
                SqlCommand attendenceLog = new SqlCommand("INSERT INTO Attendence(StudentNumber, Time, Day, Month, Year) VALUES ('" + studentNumber + "','" + today.ToString("HH:mm") + "','" + today.ToString("dddd") + "','" + today.ToString("MMMM") + "','" + today.Year + "')", membersDatabase);
                attendenceLog.ExecuteNonQuery();
                checkMemberText.Text = "";
            }
        }
    }
}
