
namespace Gestion_Patrimoine
{
    partial class Dashboard
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.affectationBtn = new System.Windows.Forms.Button();
            this.employeeBtn = new System.Windows.Forms.Button();
            this.patrimoineBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.addEmployeeBtn = new System.Windows.Forms.Button();
            this.demandeAffectationBtn = new System.Windows.Forms.Button();
            this.modifierPatrimoineBtn = new System.Windows.Forms.Button();
            this.supprimerPatrimoineBtn = new System.Windows.Forms.Button();
            this.acceptDemandeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(145, 75);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(655, 275);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.affectationBtn);
            this.panel1.Controls.Add(this.employeeBtn);
            this.panel1.Controls.Add(this.patrimoineBtn);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 452);
            this.panel1.TabIndex = 1;
            // 
            // affectationBtn
            // 
            this.affectationBtn.BackColor = System.Drawing.Color.White;
            this.affectationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.affectationBtn.ForeColor = System.Drawing.Color.Black;
            this.affectationBtn.Location = new System.Drawing.Point(0, 201);
            this.affectationBtn.Name = "affectationBtn";
            this.affectationBtn.Size = new System.Drawing.Size(144, 50);
            this.affectationBtn.TabIndex = 2;
            this.affectationBtn.Text = "Affectation";
            this.affectationBtn.UseVisualStyleBackColor = false;
            this.affectationBtn.Click += new System.EventHandler(this.affectationBtn_Click);
            // 
            // employeeBtn
            // 
            this.employeeBtn.BackColor = System.Drawing.Color.White;
            this.employeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeeBtn.ForeColor = System.Drawing.Color.Black;
            this.employeeBtn.Location = new System.Drawing.Point(0, 118);
            this.employeeBtn.Name = "employeeBtn";
            this.employeeBtn.Size = new System.Drawing.Size(144, 50);
            this.employeeBtn.TabIndex = 1;
            this.employeeBtn.Text = "Employees";
            this.employeeBtn.UseVisualStyleBackColor = false;
            this.employeeBtn.Click += new System.EventHandler(this.employeeBtn_Click);
            // 
            // patrimoineBtn
            // 
            this.patrimoineBtn.BackColor = System.Drawing.Color.Crimson;
            this.patrimoineBtn.FlatAppearance.BorderSize = 0;
            this.patrimoineBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patrimoineBtn.ForeColor = System.Drawing.Color.White;
            this.patrimoineBtn.Location = new System.Drawing.Point(0, 47);
            this.patrimoineBtn.Name = "patrimoineBtn";
            this.patrimoineBtn.Size = new System.Drawing.Size(144, 50);
            this.patrimoineBtn.TabIndex = 0;
            this.patrimoineBtn.Text = "Patrimoine";
            this.patrimoineBtn.UseVisualStyleBackColor = false;
            this.patrimoineBtn.Click += new System.EventHandler(this.patrimoineBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Espace Admin";
            // 
            // addEmployeeBtn
            // 
            this.addEmployeeBtn.BackColor = System.Drawing.Color.White;
            this.addEmployeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmployeeBtn.ForeColor = System.Drawing.Color.Black;
            this.addEmployeeBtn.Location = new System.Drawing.Point(656, 24);
            this.addEmployeeBtn.Name = "addEmployeeBtn";
            this.addEmployeeBtn.Size = new System.Drawing.Size(117, 32);
            this.addEmployeeBtn.TabIndex = 2;
            this.addEmployeeBtn.Text = "Ajouter Employee";
            this.addEmployeeBtn.UseVisualStyleBackColor = false;
            this.addEmployeeBtn.Click += new System.EventHandler(this.addEmployeeBtn_Click);
            // 
            // demandeAffectationBtn
            // 
            this.demandeAffectationBtn.BackColor = System.Drawing.Color.White;
            this.demandeAffectationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.demandeAffectationBtn.ForeColor = System.Drawing.Color.Black;
            this.demandeAffectationBtn.Location = new System.Drawing.Point(486, 24);
            this.demandeAffectationBtn.Name = "demandeAffectationBtn";
            this.demandeAffectationBtn.Size = new System.Drawing.Size(148, 32);
            this.demandeAffectationBtn.TabIndex = 3;
            this.demandeAffectationBtn.Text = "Demandes d\'affectation";
            this.demandeAffectationBtn.UseVisualStyleBackColor = false;
            this.demandeAffectationBtn.Click += new System.EventHandler(this.demandeAffectationBtn_Click);
            // 
            // modifierPatrimoineBtn
            // 
            this.modifierPatrimoineBtn.BackColor = System.Drawing.Color.White;
            this.modifierPatrimoineBtn.Enabled = false;
            this.modifierPatrimoineBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifierPatrimoineBtn.ForeColor = System.Drawing.Color.Black;
            this.modifierPatrimoineBtn.Location = new System.Drawing.Point(178, 384);
            this.modifierPatrimoineBtn.Name = "modifierPatrimoineBtn";
            this.modifierPatrimoineBtn.Size = new System.Drawing.Size(140, 32);
            this.modifierPatrimoineBtn.TabIndex = 4;
            this.modifierPatrimoineBtn.Text = "Modifier patrimoine";
            this.modifierPatrimoineBtn.UseVisualStyleBackColor = false;
            this.modifierPatrimoineBtn.Click += new System.EventHandler(this.modifierPatrimoineBtn_Click);
            // 
            // supprimerPatrimoineBtn
            // 
            this.supprimerPatrimoineBtn.BackColor = System.Drawing.Color.White;
            this.supprimerPatrimoineBtn.Enabled = false;
            this.supprimerPatrimoineBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supprimerPatrimoineBtn.ForeColor = System.Drawing.Color.Black;
            this.supprimerPatrimoineBtn.Location = new System.Drawing.Point(347, 384);
            this.supprimerPatrimoineBtn.Name = "supprimerPatrimoineBtn";
            this.supprimerPatrimoineBtn.Size = new System.Drawing.Size(141, 32);
            this.supprimerPatrimoineBtn.TabIndex = 5;
            this.supprimerPatrimoineBtn.Text = "supprimer patrimoine";
            this.supprimerPatrimoineBtn.UseVisualStyleBackColor = false;
            this.supprimerPatrimoineBtn.Click += new System.EventHandler(this.supprimerPatrimoineBtn_Click);
            // 
            // acceptDemandeBtn
            // 
            this.acceptDemandeBtn.BackColor = System.Drawing.Color.White;
            this.acceptDemandeBtn.Enabled = false;
            this.acceptDemandeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptDemandeBtn.ForeColor = System.Drawing.Color.Black;
            this.acceptDemandeBtn.Location = new System.Drawing.Point(513, 384);
            this.acceptDemandeBtn.Name = "acceptDemandeBtn";
            this.acceptDemandeBtn.Size = new System.Drawing.Size(141, 32);
            this.acceptDemandeBtn.TabIndex = 6;
            this.acceptDemandeBtn.Text = "accept demande";
            this.acceptDemandeBtn.UseVisualStyleBackColor = false;
            this.acceptDemandeBtn.Click += new System.EventHandler(this.acceptDemandeBtn_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.acceptDemandeBtn);
            this.Controls.Add(this.supprimerPatrimoineBtn);
            this.Controls.Add(this.modifierPatrimoineBtn);
            this.Controls.Add(this.demandeAffectationBtn);
            this.Controls.Add(this.addEmployeeBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView);
            this.MinimizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button employeeBtn;
        private System.Windows.Forms.Button patrimoineBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addEmployeeBtn;
        private System.Windows.Forms.Button demandeAffectationBtn;
        private System.Windows.Forms.Button modifierPatrimoineBtn;
        private System.Windows.Forms.Button supprimerPatrimoineBtn;
        private System.Windows.Forms.Button acceptDemandeBtn;
        private System.Windows.Forms.Button affectationBtn;
    }
}