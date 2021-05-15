
namespace Gestion_Patrimoine
{
    partial class Profile
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.patrimoineBtn = new System.Windows.Forms.Button();
            this.patrimoineGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.demanderPatrimoineBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patrimoineGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.patrimoineBtn);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(151, 452);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(4, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "Profile";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // patrimoineBtn
            // 
            this.patrimoineBtn.BackColor = System.Drawing.Color.Crimson;
            this.patrimoineBtn.FlatAppearance.BorderSize = 0;
            this.patrimoineBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patrimoineBtn.ForeColor = System.Drawing.Color.White;
            this.patrimoineBtn.Location = new System.Drawing.Point(4, 90);
            this.patrimoineBtn.Name = "patrimoineBtn";
            this.patrimoineBtn.Size = new System.Drawing.Size(146, 47);
            this.patrimoineBtn.TabIndex = 0;
            this.patrimoineBtn.Text = "Patrimoines";
            this.patrimoineBtn.UseVisualStyleBackColor = false;
            this.patrimoineBtn.Click += new System.EventHandler(this.patrimoineBtn_Click);
            // 
            // patrimoineGridView
            // 
            this.patrimoineGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patrimoineGridView.Location = new System.Drawing.Point(152, 75);
            this.patrimoineGridView.Name = "patrimoineGridView";
            this.patrimoineGridView.RowTemplate.Height = 25;
            this.patrimoineGridView.Size = new System.Drawing.Size(647, 285);
            this.patrimoineGridView.TabIndex = 1;
            this.patrimoineGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patrimoineGridView_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Espace Employee";
            // 
            // demanderPatrimoineBtn
            // 
            this.demanderPatrimoineBtn.BackColor = System.Drawing.Color.White;
            this.demanderPatrimoineBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.demanderPatrimoineBtn.ForeColor = System.Drawing.Color.Black;
            this.demanderPatrimoineBtn.Location = new System.Drawing.Point(182, 382);
            this.demanderPatrimoineBtn.Name = "demanderPatrimoineBtn";
            this.demanderPatrimoineBtn.Size = new System.Drawing.Size(133, 37);
            this.demanderPatrimoineBtn.TabIndex = 2;
            this.demanderPatrimoineBtn.Text = "Demander patrimoine";
            this.demanderPatrimoineBtn.UseVisualStyleBackColor = false;
            this.demanderPatrimoineBtn.Click += new System.EventHandler(this.demanderPatrimoineBtn_Click);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.demanderPatrimoineBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.patrimoineGridView);
            this.Controls.Add(this.panel1);
            this.Name = "Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.patrimoineGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView patrimoineGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button patrimoineBtn;
        private System.Windows.Forms.Button demanderPatrimoineBtn;
    }
}