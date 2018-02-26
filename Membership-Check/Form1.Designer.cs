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
            this.checkMemberButton = new System.Windows.Forms.Button();
            this.checkMemberLabel = new System.Windows.Forms.Label();
            this.checkMemberText = new System.Windows.Forms.TextBox();
            this.esportsLogo = new System.Windows.Forms.PictureBox();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.openCSV = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.esportsLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // checkMemberButton
            // 
            this.checkMemberButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkMemberButton.BackColor = System.Drawing.Color.DarkOrange;
            this.checkMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkMemberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkMemberButton.ForeColor = System.Drawing.Color.Transparent;
            this.checkMemberButton.Location = new System.Drawing.Point(503, 728);
            this.checkMemberButton.Margin = new System.Windows.Forms.Padding(0);
            this.checkMemberButton.Name = "checkMemberButton";
            this.checkMemberButton.Size = new System.Drawing.Size(300, 70);
            this.checkMemberButton.TabIndex = 7;
            this.checkMemberButton.Text = "LOGIN";
            this.checkMemberButton.UseVisualStyleBackColor = false;
            this.checkMemberButton.Click += new System.EventHandler(this.checkMemberButton_Click);
            // 
            // checkMemberLabel
            // 
            this.checkMemberLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkMemberLabel.AutoSize = true;
            this.checkMemberLabel.BackColor = System.Drawing.Color.Transparent;
            this.checkMemberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkMemberLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkMemberLabel.Location = new System.Drawing.Point(225, 543);
            this.checkMemberLabel.Margin = new System.Windows.Forms.Padding(0);
            this.checkMemberLabel.Name = "checkMemberLabel";
            this.checkMemberLabel.Size = new System.Drawing.Size(819, 61);
            this.checkMemberLabel.TabIndex = 6;
            this.checkMemberLabel.Text = "Please enter your student number";
            this.checkMemberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkMemberText
            // 
            this.checkMemberText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkMemberText.BackColor = System.Drawing.Color.White;
            this.checkMemberText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkMemberText.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkMemberText.Location = new System.Drawing.Point(236, 620);
            this.checkMemberText.Margin = new System.Windows.Forms.Padding(0);
            this.checkMemberText.Name = "checkMemberText";
            this.checkMemberText.Size = new System.Drawing.Size(842, 67);
            this.checkMemberText.TabIndex = 5;
            this.checkMemberText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // esportsLogo
            // 
            this.esportsLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.esportsLogo.BackColor = System.Drawing.Color.Transparent;
            this.esportsLogo.Image = ((System.Drawing.Image)(resources.GetObject("esportsLogo.Image")));
            this.esportsLogo.Location = new System.Drawing.Point(258, 32);
            this.esportsLogo.Margin = new System.Windows.Forms.Padding(0);
            this.esportsLogo.Name = "esportsLogo";
            this.esportsLogo.Size = new System.Drawing.Size(800, 400);
            this.esportsLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.esportsLogo.TabIndex = 6;
            this.esportsLogo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1283, 912);
            this.Controls.Add(this.checkMemberButton);
            this.Controls.Add(this.esportsLogo);
            this.Controls.Add(this.checkMemberLabel);
            this.Controls.Add(this.checkMemberText);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "QUT eSports";
            ((System.ComponentModel.ISupportInitialize)(this.esportsLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button checkMemberButton;
        private System.Windows.Forms.Label checkMemberLabel;
        private System.Windows.Forms.TextBox checkMemberText;
        private System.Windows.Forms.PictureBox esportsLogo;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.OpenFileDialog openCSV;
    }
}

