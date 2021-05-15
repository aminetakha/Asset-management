
namespace Gestion_Patrimoine
{
    partial class UpdateProfile
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.firstnameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lastnameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ageBox = new System.Windows.Forms.TextBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update Profile";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Firstname";
            // 
            // firstnameBox
            // 
            this.firstnameBox.Location = new System.Drawing.Point(374, 126);
            this.firstnameBox.Name = "firstnameBox";
            this.firstnameBox.Size = new System.Drawing.Size(215, 23);
            this.firstnameBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lastname";
            // 
            // lastnameBox
            // 
            this.lastnameBox.Location = new System.Drawing.Point(374, 187);
            this.lastnameBox.Name = "lastnameBox";
            this.lastnameBox.Size = new System.Drawing.Size(215, 23);
            this.lastnameBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Age";
            // 
            // ageBox
            // 
            this.ageBox.Location = new System.Drawing.Point(374, 255);
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(215, 23);
            this.ageBox.TabIndex = 6;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(333, 339);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(116, 45);
            this.updateBtn.TabIndex = 7;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // UpdateProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lastnameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.firstnameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstnameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lastnameBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ageBox;
        private System.Windows.Forms.Button updateBtn;
    }
}