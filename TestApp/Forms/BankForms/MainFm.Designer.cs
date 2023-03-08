namespace TestApp.Forms.BankForms
{
    partial class MainFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFm));
            this.MehrCodeLandBtn = new System.Windows.Forms.Button();
            this.WomanLifeFreedomBtn = new System.Windows.Forms.Button();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.BankNameBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MehrCodeLandBtn
            // 
            this.MehrCodeLandBtn.BackColor = System.Drawing.Color.IndianRed;
            this.MehrCodeLandBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MehrCodeLandBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MehrCodeLandBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MehrCodeLandBtn.Location = new System.Drawing.Point(269, 199);
            this.MehrCodeLandBtn.Name = "MehrCodeLandBtn";
            this.MehrCodeLandBtn.Size = new System.Drawing.Size(138, 49);
            this.MehrCodeLandBtn.TabIndex = 1;
            this.MehrCodeLandBtn.Text = "MehrCodeLand";
            this.MehrCodeLandBtn.UseVisualStyleBackColor = false;
            this.MehrCodeLandBtn.Click += new System.EventHandler(this.MehrCodeLandBtn_Click);
            // 
            // WomanLifeFreedomBtn
            // 
            this.WomanLifeFreedomBtn.BackColor = System.Drawing.Color.IndianRed;
            this.WomanLifeFreedomBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WomanLifeFreedomBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.WomanLifeFreedomBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WomanLifeFreedomBtn.Location = new System.Drawing.Point(269, 254);
            this.WomanLifeFreedomBtn.Name = "WomanLifeFreedomBtn";
            this.WomanLifeFreedomBtn.Size = new System.Drawing.Size(279, 49);
            this.WomanLifeFreedomBtn.TabIndex = 2;
            this.WomanLifeFreedomBtn.Text = "Woman Life Freedom";
            this.WomanLifeFreedomBtn.UseVisualStyleBackColor = false;
            this.WomanLifeFreedomBtn.Click += new System.EventHandler(this.WomanLifeFreedomBtn_Click);
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.LightCoral;
            this.LoginBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoginBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoginBtn.Location = new System.Drawing.Point(410, 115);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(138, 133);
            this.LoginBtn.TabIndex = 3;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // BankNameBtn
            // 
            this.BankNameBtn.BackColor = System.Drawing.Color.IndianRed;
            this.BankNameBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BankNameBtn.CausesValidation = false;
            this.BankNameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BankNameBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BankNameBtn.Location = new System.Drawing.Point(269, 115);
            this.BankNameBtn.Name = "BankNameBtn";
            this.BankNameBtn.Size = new System.Drawing.Size(138, 79);
            this.BankNameBtn.TabIndex = 0;
            this.BankNameBtn.TabStop = false;
            this.BankNameBtn.Text = "Freedom Bank";
            this.BankNameBtn.UseVisualStyleBackColor = false;
            this.BankNameBtn.Click += new System.EventHandler(this.BankNameBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Tomato;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExitBtn.Location = new System.Drawing.Point(373, 312);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 32);
            this.ExitBtn.TabIndex = 4;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // MainFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.WomanLifeFreedomBtn);
            this.Controls.Add(this.MehrCodeLandBtn);
            this.Controls.Add(this.BankNameBtn);
            this.Name = "MainFm";
            this.Text = "MainFm";
            this.ResumeLayout(false);

        }

        #endregion
        private Button MehrCodeLandBtn;
        private Button WomanLifeFreedomBtn;
        private Button LoginBtn;
        private Button BankNameBtn;
        private Button ExitBtn;
    }
}