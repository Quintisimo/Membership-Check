namespace QUT_eSports_Membership {
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
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // addMemberText
            // 
            this.addMemberText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMemberText.Location = new System.Drawing.Point(32, 157);
            this.addMemberText.Name = "addMemberText";
            this.addMemberText.Size = new System.Drawing.Size(425, 38);
            this.addMemberText.TabIndex = 1;
            // 
            // addMemberLabel
            // 
            this.addMemberLabel.AutoSize = true;
            this.addMemberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMemberLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addMemberLabel.Location = new System.Drawing.Point(26, 100);
            this.addMemberLabel.Name = "addMemberLabel";
            this.addMemberLabel.Size = new System.Drawing.Size(211, 31);
            this.addMemberLabel.TabIndex = 3;
            this.addMemberLabel.Text = "Student Number";
            // 
            // addMemberButton
            // 
            this.addMemberButton.Location = new System.Drawing.Point(151, 248);
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
            this.tabControl1.Location = new System.Drawing.Point(35, 31);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(490, 427);
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
            this.tabPage1.Size = new System.Drawing.Size(474, 380);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Membership";
            // 
            // checkMemberButton
            // 
            this.checkMemberButton.Location = new System.Drawing.Point(151, 248);
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
            this.checkMemberLabel.Location = new System.Drawing.Point(26, 100);
            this.checkMemberLabel.Name = "checkMemberLabel";
            this.checkMemberLabel.Size = new System.Drawing.Size(211, 31);
            this.checkMemberLabel.TabIndex = 6;
            this.checkMemberLabel.Text = "Student Number";
            // 
            // checkMemberText
            // 
            this.checkMemberText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkMemberText.Location = new System.Drawing.Point(32, 157);
            this.checkMemberText.Name = "checkMemberText";
            this.checkMemberText.Size = new System.Drawing.Size(425, 38);
            this.checkMemberText.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tabPage2.Controls.Add(this.addMemberButton);
            this.tabPage2.Controls.Add(this.addMemberLabel);
            this.tabPage2.Controls.Add(this.addMemberText);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(474, 380);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add User";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(550, 490);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "QUT eSports";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
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
    }
}

