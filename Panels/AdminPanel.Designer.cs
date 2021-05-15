
namespace Gestion_Patrimoine.Panels
{
    partial class AdminPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.adminLoginBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Espace Admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(180, 103);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(223, 23);
            this.emailBox.TabIndex = 2;
            this.emailBox.TextChanged += new System.EventHandler(this.emailBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(180, 152);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(223, 23);
            this.passwordBox.TabIndex = 4;
            // 
            // adminLoginBtn
            // 
            this.adminLoginBtn.Location = new System.Drawing.Point(194, 222);
            this.adminLoginBtn.Name = "adminLoginBtn";
            this.adminLoginBtn.Size = new System.Drawing.Size(75, 23);
            this.adminLoginBtn.TabIndex = 5;
            this.adminLoginBtn.Text = "Login";
            this.adminLoginBtn.UseVisualStyleBackColor = true;
            this.adminLoginBtn.Click += new System.EventHandler(this.adminLoginBtn_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.adminLoginBtn);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdminPanel";
            this.Size = new System.Drawing.Size(494, 292);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button adminLoginBtn;
    }
}
