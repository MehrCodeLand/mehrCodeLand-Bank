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
            this.Back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Back_btn
            // 
            this.Back_btn.BackColor = System.Drawing.Color.LightCoral;
            this.Back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Back_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Back_btn.Location = new System.Drawing.Point(12, 474);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(143, 47);
            this.Back_btn.TabIndex = 0;
            this.Back_btn.Text = "Back";
            this.Back_btn.UseVisualStyleBackColor = false;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // UserPannelFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CodeLandBank.Properties.Resources.DSC_0175;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(907, 554);
            this.Controls.Add(this.Back_btn);
            this.Name = "UserPannelFm";
            this.Text = "UserPannelFm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button Back_btn;
    }
}