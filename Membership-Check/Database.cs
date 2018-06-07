using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Membership_Check {
    class Database {
        /// <summary>
        /// Tries to connect to the database and if it cant throws an error
        /// </summary>
        /// <returns>database</returns>
        public static SqlConnection connect() {
            SqlConnection membersDatabase = new SqlConnection("Data Source=qutesports.database.windows.net;Initial Catalog=qutesportsMembership;Persist Security Info=True;User ID=qutesports;Password=Lagswitch1");
            try {
                membersDatabase.Open();
            } catch {
                return null;
            }
            return membersDatabase;
        }

        /// <summary>
        /// Disconnects from currently conected database
        /// </summary>
        /// <param name="database">connected database</param>
        public static void disconnect(SqlConnection database) {
            try {
                database.Close();
            } catch (Exception error) {
                MessageBox.Show(error.ToString(), "Disconnect", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Checks if paid or not
        /// </summary>
        /// <param name="student">student number</param>
        /// <param name="database">connected database</param>
        /// <returns>true if paid otherwise false</returns>
        public static bool paid(String student, SqlConnection database) {
            SqlCommand paidStatus = new SqlCommand("SELECT Paid FROM Members WHERE StudentNumber = '" + student + "'", database);
            string paid = Convert.ToString(paidStatus.ExecuteScalar());

            if (paid == "Yes") {
                return true;
            } else {
                return false;
            }
        }

        /// <summary>
        /// Adds attendance when logged in
        /// </summary>
        /// <param name="student">student number</param>
        /// <param name="date">current date</param>
        /// <param name="database">connected database</param>
        public static void attend(String student, DateTime date, SqlConnection database) {
            SqlCommand attendanceLog = new SqlCommand("INSERT INTO Attendance(StudentNumber, Time, Day, Month, Year) VALUES ('" + student + "','" + date.ToString("HH:mm") + "','" + date.ToString("dd") + "','" + date.ToString("MMMM") + "','" + date.Year + "')", database);
            attendanceLog.ExecuteNonQuery();
        }

        /// <summary>
        /// Adds a free use
        /// </summary>
        /// <param name="student">student number</param>
        /// <param name="database">connected database</param>
        public static void addUse(String student, SqlConnection database) {
            try {
                SqlCommand addMember = new SqlCommand("INSERT INTO Members(StudentNumber, Paid, FreeUse) VALUES ('" + student + "', 'No', 1)", database);
                addMember.ExecuteNonQuery();
            } catch {
                SqlCommand updateUse = new SqlCommand("UPDATE Members SET FreeUse = FreeUse + 1", database);
                updateUse.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Gets free uses
        /// </summary>
        /// <param name="student">student number</param>
        /// <param name="database">connected database</param>
        /// <returns>free uses</returns>
        public static int? getUse(String student, SqlConnection database) {
            int? uses;
            try {
                SqlCommand checkUses = new SqlCommand("SELECT FreeUse FROM Members WHERE StudentNumber ='" + student + "'", database);
                uses = Convert.ToInt32(checkUses.ExecuteScalar());
            } catch {
                uses = null;
            }
            return uses;
        }
    } 
}
