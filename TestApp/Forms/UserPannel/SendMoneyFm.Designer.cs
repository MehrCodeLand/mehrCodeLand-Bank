namespace CodeLandBank.Forms.UserPannel
{
    partial class SendMoneyFm
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
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SendBtn = new System.Windows.Forms.Button();
            this.SecendUserNumberTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MoneyTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.Tomato;
            this.CancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancelBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CancelBtn.Location = new System.Drawing.Point(333, 239);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(103, 28);
            this.CancelBtn.TabIndex = 0;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SendBtn
            // 
            this.SendBtn.BackColor = System.Drawing.Color.Tomato;
            this.SendBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SendBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SendBtn.Location = new System.Drawing.Point(474, 239);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(103, 28);
            this.SendBtn.TabIndex = 1;
            this.SendBtn.Text = "Sned";
            this.SendBtn.UseVisualStyleBackColor = false;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // SecendUserNumberTB
            // 
            this.SecendUserNumberTB.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SecendUserNumberTB.Location = new System.Drawing.Point(333, 158);
            this.SecendUserNumberTB.Name = "SecendUserNumberTB";
            this.SecendUserNumberTB.Size = new System.Drawing.Size(244, 27);
            this.SecendUserNumberTB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(206, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "userCardNumber";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(273, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Money";
            // 
            // MoneyTB
            // 
            this.MoneyTB.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MoneyTB.Location = new System.Drawing.Point(333, 191);
            this.MoneyTB.Name = "MoneyTB";
            this.MoneyTB.Size = new System.Drawing.Size(244, 27);
            this.MoneyTB.TabIndex = 4;
            // 
            // SendMoneyFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CodeLandBank.Properties.Resources.DSC_0175;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MoneyTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SecendUserNumberTB);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.CancelBtn);
            this.Name = "SendMoneyFm";
            this.Text = "Send Money";
            this.Load += new System.EventHandler(this.SendMoneyFm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button CancelBtn;
        private Button SendBtn;
        private TextBox SecendUserNumberTB;
        private Label label1;
        private Label label2;
        private TextBox MoneyTB;
    }
}