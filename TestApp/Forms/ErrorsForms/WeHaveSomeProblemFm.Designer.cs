namespace CodeLandBank.Forms.ErrorsForms
{
    partial class WeHaveSomeProblemFm
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
            this.restartAppbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // restartAppbtn
            // 
            this.restartAppbtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.restartAppbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.restartAppbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.restartAppbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.restartAppbtn.Location = new System.Drawing.Point(301, 181);
            this.restartAppbtn.Name = "restartAppbtn";
            this.restartAppbtn.Size = new System.Drawing.Size(179, 69);
            this.restartAppbtn.TabIndex = 0;
            this.restartAppbtn.Text = "Restart App";
            this.restartAppbtn.UseVisualStyleBackColor = false;
            this.restartAppbtn.Click += new System.EventHandler(this.restartAppbtn_Click);
            // 
            // WeHaveSomeProblemFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CodeLandBank.Properties.Resources.DSC_0175;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.restartAppbtn);
            this.Name = "WeHaveSomeProblemFm";
            this.Text = "WeHaveSomeProblemFm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button restartAppbtn;
    }
}