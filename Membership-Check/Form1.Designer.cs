﻿namespace QUT_eSports_Membership {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.addMemberText = new System.Windows.Forms.TextBox();
            this.addMemberLabel = new System.Windows.Forms.Label();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkMemberButton = new System.Windows.Forms.Button();
            this.checkMemberLabel = new System.Windows.Forms.Label();
            this.checkMemberText = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.importCSVButton = new System.Windows.Forms.Button();
            this.addMembersLabel = new System.Windows.Forms.Label();
            this.addMembersText = new System.Windows.Forms.TextBox();
            this.addMemberPasswordLabel = new System.Windows.Forms.Label();
            this.addMemberPasswordText = new System.Windows.Forms.TextBox();
            this.saveLocationLabel = new System.Windows.Forms.TabPage();
            this.saveLocationButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.saveLocationText = new System.Windows.Forms.TextBox();
            this.getMemberButton = new System.Windows.Forms.Button();
            this.membersAttendanceRadio = new System.Windows.Forms.RadioButton();
            this.membersListRadio = new System.Windows.Forms.RadioButton();
            this.getMembersPasswordText = new System.Windows.Forms.TextBox();
            this.getMembersPasswordLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.openCSV = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.saveLocationLabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // addMemberText
            // 
            this.addMemberText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMemberText.Location = new System.Drawing.Point(32, 191);
            this.addMemberText.Name = "addMemberText";
            this.addMemberText.Size = new System.Drawing.Size(425, 38);
            this.addMemberText.TabIndex = 1;
            // 
            // addMemberLabel
            // 
            this.addMemberLabel.AutoSize = true;
            this.addMemberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMemberLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addMemberLabel.Location = new System.Drawing.Point(25, 153);
            this.addMemberLabel.Name = "addMemberLabel";
            this.addMemberLabel.Size = new System.Drawing.Size(211, 31);
            this.addMemberLabel.TabIndex = 3;
            this.addMemberLabel.Text = "Student Number";
            // 
            // addMemberButton
            // 
            this.addMemberButton.Location = new System.Drawing.Point(151, 373);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(165, 64);
            this.addMemberButton.TabIndex = 4;
            this.addMemberButton.Text = "Submit";
            this.addMemberButton.UseVisualStyleBackColor = true;
            this.addMemberButton.Click += new System.EventHandler(this.addMemberButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.saveLocationLabel);
            this.tabControl1.Location = new System.Drawing.Point(457, 42);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(490, 518);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tabPage1.Controls.Add(this.checkMemberButton);
            this.tabPage1.Controls.Add(this.checkMemberLabel);
            this.tabPage1.Controls.Add(this.checkMemberText);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(474, 471);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Membership";
            // 
            // checkMemberButton
            // 
            this.checkMemberButton.Location = new System.Drawing.Point(151, 287);
            this.checkMemberButton.Name = "checkMemberButton";
            this.checkMemberButton.Size = new System.Drawing.Size(165, 64);
            this.checkMemberButton.TabIndex = 7;
            this.checkMemberButton.Text = "Submit";
            this.checkMemberButton.UseVisualStyleBackColor = true;
            this.checkMemberButton.Click += new System.EventHandler(this.checkMemberButton_Click);
            // 
            // checkMemberLabel
            // 
            this.checkMemberLabel.AutoSize = true;
            this.checkMemberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkMemberLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkMemberLabel.Location = new System.Drawing.Point(26, 118);
            this.checkMemberLabel.Name = "checkMemberLabel";
            this.checkMemberLabel.Size = new System.Drawing.Size(211, 31);
            this.checkMemberLabel.TabIndex = 6;
            this.checkMemberLabel.Text = "Student Number";
            // 
            // checkMemberText
            // 
            this.checkMemberText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkMemberText.Location = new System.Drawing.Point(32, 166);
            this.checkMemberText.Name = "checkMemberText";
            this.checkMemberText.Size = new System.Drawing.Size(425, 38);
            this.checkMemberText.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tabPage2.Controls.Add(this.importCSVButton);
            this.tabPage2.Controls.Add(this.addMembersLabel);
            this.tabPage2.Controls.Add(this.addMembersText);
            this.tabPage2.Controls.Add(this.addMemberPasswordLabel);
            this.tabPage2.Controls.Add(this.addMemberPasswordText);
            this.tabPage2.Controls.Add(this.addMemberButton);
            this.tabPage2.Controls.Add(this.addMemberLabel);
            this.tabPage2.Controls.Add(this.addMemberText);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(474, 471);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add Member";
            // 
            // importCSVButton
            // 
            this.importCSVButton.Location = new System.Drawing.Point(336, 76);
            this.importCSVButton.Name = "importCSVButton";
            this.importCSVButton.Size = new System.Drawing.Size(121, 48);
            this.importCSVButton.TabIndex = 9;
            this.importCSVButton.Text = "Browse";
            this.importCSVButton.UseVisualStyleBackColor = true;
            this.importCSVButton.Click += new System.EventHandler(this.importCSVButton_Click);
            // 
            // addMembersLabel
            // 
            this.addMembersLabel.AutoSize = true;
            this.addMembersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMembersLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addMembersLabel.Location = new System.Drawing.Point(28, 39);
            this.addMembersLabel.Name = "addMembersLabel";
            this.addMembersLabel.Size = new System.Drawing.Size(181, 31);
            this.addMembersLabel.TabIndex = 8;
            this.addMembersLabel.Text = "Select csv file";
            // 
            // addMembersText
            // 
            this.addMembersText.BackColor = System.Drawing.SystemColors.Window;
            this.addMembersText.Enabled = false;
            this.addMembersText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMembersText.Location = new System.Drawing.Point(32, 76);
            this.addMembersText.Name = "addMembersText";
            this.addMembersText.Size = new System.Drawing.Size(298, 38);
            this.addMembersText.TabIndex = 7;
            // 
            // addMemberPasswordLabel
            // 
            this.addMemberPasswordLabel.AutoSize = true;
            this.addMemberPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMemberPasswordLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addMemberPasswordLabel.Location = new System.Drawing.Point(26, 258);
            this.addMemberPasswordLabel.Name = "addMemberPasswordLabel";
            this.addMemberPasswordLabel.Size = new System.Drawing.Size(134, 31);
            this.addMemberPasswordLabel.TabIndex = 6;
            this.addMemberPasswordLabel.Text = "Password";
            // 
            // addMemberPasswordText
            // 
            this.addMemberPasswordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMemberPasswordText.Location = new System.Drawing.Point(32, 295);
            this.addMemberPasswordText.Name = "addMemberPasswordText";
            this.addMemberPasswordText.PasswordChar = '*';
            this.addMemberPasswordText.Size = new System.Drawing.Size(425, 38);
            this.addMemberPasswordText.TabIndex = 5;
            // 
            // saveLocationLabel
            // 
            this.saveLocationLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.saveLocationLabel.Controls.Add(this.saveLocationButton);
            this.saveLocationLabel.Controls.Add(this.label1);
            this.saveLocationLabel.Controls.Add(this.saveLocationText);
            this.saveLocationLabel.Controls.Add(this.getMemberButton);
            this.saveLocationLabel.Controls.Add(this.membersAttendanceRadio);
            this.saveLocationLabel.Controls.Add(this.membersListRadio);
            this.saveLocationLabel.Controls.Add(this.getMembersPasswordText);
            this.saveLocationLabel.Controls.Add(this.getMembersPasswordLabel);
            this.saveLocationLabel.Location = new System.Drawing.Point(8, 39);
            this.saveLocationLabel.Name = "saveLocationLabel";
            this.saveLocationLabel.Padding = new System.Windows.Forms.Padding(3);
            this.saveLocationLabel.Size = new System.Drawing.Size(474, 471);
            this.saveLocationLabel.TabIndex = 2;
            this.saveLocationLabel.Text = "Get Members";
            // 
            // saveLocationButton
            // 
            this.saveLocationButton.Location = new System.Drawing.Point(327, 202);
            this.saveLocationButton.Name = "saveLocationButton";
            this.saveLocationButton.Size = new System.Drawing.Size(130, 49);
            this.saveLocationButton.TabIndex = 14;
            this.saveLocationButton.Text = "Browse";
            this.saveLocationButton.UseVisualStyleBackColor = true;
            this.saveLocationButton.Click += new System.EventHandler(this.saveLocationButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(27, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "Select save location";
            // 
            // saveLocationText
            // 
            this.saveLocationText.Enabled = false;
            this.saveLocationText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveLocationText.Location = new System.Drawing.Point(31, 202);
            this.saveLocationText.Name = "saveLocationText";
            this.saveLocationText.Size = new System.Drawing.Size(289, 38);
            this.saveLocationText.TabIndex = 12;
            // 
            // getMemberButton
            // 
            this.getMemberButton.Location = new System.Drawing.Point(155, 386);
            this.getMemberButton.Name = "getMemberButton";
            this.getMemberButton.Size = new System.Drawing.Size(165, 64);
            this.getMemberButton.TabIndex = 11;
            this.getMemberButton.Text = "Generate CSV";
            this.getMemberButton.UseVisualStyleBackColor = true;
            this.getMemberButton.Click += new System.EventHandler(this.getMemberButton_Click);
            // 
            // membersAttendanceRadio
            // 
            this.membersAttendanceRadio.AutoSize = true;
            this.membersAttendanceRadio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.membersAttendanceRadio.Location = new System.Drawing.Point(109, 84);
            this.membersAttendanceRadio.Name = "membersAttendanceRadio";
            this.membersAttendanceRadio.Size = new System.Drawing.Size(287, 29);
            this.membersAttendanceRadio.TabIndex = 10;
            this.membersAttendanceRadio.TabStop = true;
            this.membersAttendanceRadio.Text = "Get Members Attendance";
            this.membersAttendanceRadio.UseVisualStyleBackColor = true;
            // 
            // membersListRadio
            // 
            this.membersListRadio.AutoSize = true;
            this.membersListRadio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.membersListRadio.Location = new System.Drawing.Point(109, 35);
            this.membersListRadio.Name = "membersListRadio";
            this.membersListRadio.Size = new System.Drawing.Size(212, 29);
            this.membersListRadio.TabIndex = 9;
            this.membersListRadio.TabStop = true;
            this.membersListRadio.Text = "Get Members List";
            this.membersListRadio.UseVisualStyleBackColor = true;
            // 
            // getMembersPasswordText
            // 
            this.getMembersPasswordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getMembersPasswordText.Location = new System.Drawing.Point(32, 314);
            this.getMembersPasswordText.Name = "getMembersPasswordText";
            this.getMembersPasswordText.PasswordChar = '*';
            this.getMembersPasswordText.Size = new System.Drawing.Size(425, 38);
            this.getMembersPasswordText.TabIndex = 8;
            // 
            // getMembersPasswordLabel
            // 
            this.getMembersPasswordLabel.AutoSize = true;
            this.getMembersPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getMembersPasswordLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.getMembersPasswordLabel.Location = new System.Drawing.Point(26, 277);
            this.getMembersPasswordLabel.Name = "getMembersPasswordLabel";
            this.getMembersPasswordLabel.Size = new System.Drawing.Size(134, 31);
            this.getMembersPasswordLabel.TabIndex = 7;
            this.getMembersPasswordLabel.Text = "Password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(355, 351);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // saveFile
            // 
            this.saveFile.Filter = "Excel File (*.csv)|*.csv";
            // 
            // openCSV
            // 
            this.openCSV.Filter = "Excel File (*.csv)|*.csv";
            this.openCSV.FileOk += new System.ComponentModel.CancelEventHandler(this.openCSV_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(970, 608);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "QUT eSports";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.saveLocationLabel.ResumeLayout(false);
            this.saveLocationLabel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox addMemberText;
        private System.Windows.Forms.Label addMemberLabel;
        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button checkMemberButton;
        private System.Windows.Forms.Label checkMemberLabel;
        private System.Windows.Forms.TextBox checkMemberText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label addMemberPasswordLabel;
        private System.Windows.Forms.TextBox addMemberPasswordText;
        private System.Windows.Forms.TabPage saveLocationLabel;
        private System.Windows.Forms.TextBox getMembersPasswordText;
        private System.Windows.Forms.Label getMembersPasswordLabel;
        private System.Windows.Forms.Button getMemberButton;
        private System.Windows.Forms.RadioButton membersAttendanceRadio;
        private System.Windows.Forms.RadioButton membersListRadio;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.Button importCSVButton;
        private System.Windows.Forms.Label addMembersLabel;
        private System.Windows.Forms.TextBox addMembersText;
        private System.Windows.Forms.OpenFileDialog openCSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox saveLocationText;
        private System.Windows.Forms.Button saveLocationButton;
    }
}

