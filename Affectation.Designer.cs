
namespace Gestion_Patrimoine
{
    partial class Affectation
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
            this.label3 = new System.Windows.Forms.Label();
            this.employeeComboBox = new System.Windows.Forms.ComboBox();
            this.patrimoineComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Affectation des patrimoines";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Patrimoine";
            // 
            // employeeComboBox
            // 
            this.employeeComboBox.FormattingEnabled = true;
            this.employeeComboBox.Location = new System.Drawing.Point(308, 169);
            this.employeeComboBox.Name = "employeeComboBox";
            this.employeeComboBox.Size = new System.Drawing.Size(261, 23);
            this.employeeComboBox.TabIndex = 3;
            // 
            // patrimoineComboBox
            // 
            this.patrimoineComboBox.FormattingEnabled = true;
            this.patrimoineComboBox.Location = new System.Drawing.Point(308, 237);
            this.patrimoineComboBox.Name = "patrimoineComboBox";
            this.patrimoineComboBox.Size = new System.Drawing.Size(261, 23);
            this.patrimoineComboBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(350, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "Affecter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Affectation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.patrimoineComboBox);
            this.Controls.Add(this.employeeComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Affectation";
            this.Text = "Affectation";
            this.Load += new System.EventHandler(this.Affectation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox employeeComboBox;
        private System.Windows.Forms.ComboBox patrimoineComboBox;
        private System.Windows.Forms.Button button1;
    }
}