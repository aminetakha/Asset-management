
namespace Gestion_Patrimoine.Panels
{
    partial class EmployePanel
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
            this.employeeLoginBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Espace Employé";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(208, 100);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(198, 23);
            this.emailBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(208, 156);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(198, 23);
            this.passwordBox.TabIndex = 4;
            // 
            // employeeLoginBtn
            // 
            this.employeeLoginBtn.Location = new System.Drawing.Point(208, 212);
            this.employeeLoginBtn.Name = "employeeLoginBtn";
            this.employeeLoginBtn.Size = new System.Drawing.Size(75, 23);
            this.employeeLoginBtn.TabIndex = 5;
            this.employeeLoginBtn.Text = "Login";
            this.employeeLoginBtn.UseVisualStyleBackColor = true;
            this.employeeLoginBtn.Click += new System.EventHandler(this.employeeLoginBtn_Click);
            // 
            // EmployePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.employeeLoginBtn);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EmployePanel";
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
        private System.Windows.Forms.Button employeeLoginBtn;
    }
}
