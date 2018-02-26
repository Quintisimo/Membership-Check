using System;
using System.Windows.Forms;

namespace Membership_Check {
    public partial class Form2 : Form {
        public Form2() {
            InitializeComponent();
        }

        private void logoutButton_Click(object sender, EventArgs e) {
            this.Hide();
            Form loginForm = new Form1();
            loginForm.Show();
        }
    }
}
