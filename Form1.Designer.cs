
namespace Gestion_Patrimoine
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginPanel = new System.Windows.Forms.Panel();
            this.adminBtn = new System.Windows.Forms.Button();
            this.employeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginPanel
            // 
            this.loginPanel.Location = new System.Drawing.Point(149, 94);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(494, 292);
            this.loginPanel.TabIndex = 0;
            // 
            // adminBtn
            // 
            this.adminBtn.Location = new System.Drawing.Point(588, 28);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.Size = new System.Drawing.Size(75, 23);
            this.adminBtn.TabIndex = 1;
            this.adminBtn.Text = "admin";
            this.adminBtn.UseVisualStyleBackColor = true;
            this.adminBtn.Click += new System.EventHandler(this.adminBtn_Click);
            // 
            // employeBtn
            // 
            this.employeBtn.Location = new System.Drawing.Point(494, 27);
            this.employeBtn.Name = "employeBtn";
            this.employeBtn.Size = new System.Drawing.Size(75, 23);
            this.employeBtn.TabIndex = 2;
            this.employeBtn.Text = "employe";
            this.employeBtn.UseVisualStyleBackColor = true;
            this.employeBtn.Click += new System.EventHandler(this.employeBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.employeBtn);
            this.Controls.Add(this.adminBtn);
            this.Controls.Add(this.loginPanel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Button adminBtn;
        private System.Windows.Forms.Button employeBtn;
    }
}

