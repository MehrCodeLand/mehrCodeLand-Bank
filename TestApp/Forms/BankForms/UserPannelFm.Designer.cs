namespace CodeLandBank.Forms.BankForms
{
    partial class UserPannelFm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.usernameData = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.seeYourProfileBtn = new System.Windows.Forms.Button();
            this.SendMoneyBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cardNumberbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // usernameData
            // 
            this.usernameData.BackColor = System.Drawing.SystemColors.ControlDark;
            this.usernameData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameData.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.usernameData.Location = new System.Drawing.Point(12, 19);
            this.usernameData.Name = "usernameData";
            this.usernameData.ReadOnly = true;
            this.usernameData.Size = new System.Drawing.Size(144, 20);
            this.usernameData.TabIndex = 1;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(37, 42);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(0, 15);
            this.labelUsername.TabIndex = 2;
            // 
            // seeYourProfileBtn
            // 
            this.seeYourProfileBtn.BackColor = System.Drawing.Color.Tomato;
            this.seeYourProfileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.seeYourProfileBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.seeYourProfileBtn.Location = new System.Drawing.Point(255, 128);
            this.seeYourProfileBtn.Margin = new System.Windows.Forms.Padding(2);
            this.seeYourProfileBtn.Name = "seeYourProfileBtn";
            this.seeYourProfileBtn.Size = new System.Drawing.Size(136, 28);
            this.seeYourProfileBtn.TabIndex = 3;
            this.seeYourProfileBtn.Text = "See Your Profile";
            this.seeYourProfileBtn.UseVisualStyleBackColor = false;
            this.seeYourProfileBtn.Click += new System.EventHandler(this.seeYourProfileBtn_Click);
            // 
            // SendMoneyBtn
            // 
            this.SendMoneyBtn.BackColor = System.Drawing.Color.Tomato;
            this.SendMoneyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SendMoneyBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SendMoneyBtn.Location = new System.Drawing.Point(255, 160);
            this.SendMoneyBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SendMoneyBtn.Name = "SendMoneyBtn";
            this.SendMoneyBtn.Size = new System.Drawing.Size(136, 28);
            this.SendMoneyBtn.TabIndex = 4;
            this.SendMoneyBtn.Text = "Send Money";
            this.SendMoneyBtn.UseVisualStyleBackColor = false;
            this.SendMoneyBtn.Click += new System.EventHandler(this.SendMoneyBtn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCoral;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(524, 284);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 7;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cardNumberbox
            // 
            this.cardNumberbox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cardNumberbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cardNumberbox.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cardNumberbox.Location = new System.Drawing.Point(12, 45);
            this.cardNumberbox.Name = "cardNumberbox";
            this.cardNumberbox.ReadOnly = true;
            this.cardNumberbox.Size = new System.Drawing.Size(144, 20);
            this.cardNumberbox.TabIndex = 8;
            // 
            // UserPannelFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CodeLandBank.Properties.Resources.DSC_0175;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(635, 332);
            this.Controls.Add(this.cardNumberbox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SendMoneyBtn);
            this.Controls.Add(this.seeYourProfileBtn);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.usernameData);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserPannelFm";
            this.Text = "UserPannelFm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox usernameData;
        private Label labelUsername;
        private Button seeYourProfileBtn;
        private Button SendMoneyBtn;
        private Button button2;
        private TextBox cardNumberbox;
    }
}