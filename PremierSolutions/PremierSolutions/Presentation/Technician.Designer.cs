namespace PremierSolutions
{
    partial class Form3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtq = new System.Windows.Forms.TextBox();
            this.txtability = new System.Windows.Forms.TextBox();
            this.DeleteT = new System.Windows.Forms.Button();
            this.UpdateT = new System.Windows.Forms.Button();
            this.InsertT = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAbilities = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MainMenu = new System.Windows.Forms.Button();
            this.Employee = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.btnNextForm = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtq);
            this.groupBox1.Controls.Add(this.txtability);
            this.groupBox1.Controls.Add(this.DeleteT);
            this.groupBox1.Controls.Add(this.UpdateT);
            this.groupBox1.Controls.Add(this.InsertT);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAbilities);
            this.groupBox1.ForeColor = System.Drawing.Color.Magenta;
            this.groupBox1.Location = new System.Drawing.Point(55, 81);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(908, 311);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Technician";
            // 
            // txtq
            // 
            this.txtq.Location = new System.Drawing.Point(153, 139);
            this.txtq.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtq.Name = "txtq";
            this.txtq.Size = new System.Drawing.Size(132, 22);
            this.txtq.TabIndex = 6;
            // 
            // txtability
            // 
            this.txtability.Location = new System.Drawing.Point(153, 74);
            this.txtability.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtability.Name = "txtability";
            this.txtability.Size = new System.Drawing.Size(132, 22);
            this.txtability.TabIndex = 5;
            // 
            // DeleteT
            // 
            this.DeleteT.BackColor = System.Drawing.SystemColors.Desktop;
            this.DeleteT.Location = new System.Drawing.Point(376, 215);
            this.DeleteT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteT.Name = "DeleteT";
            this.DeleteT.Size = new System.Drawing.Size(112, 47);
            this.DeleteT.TabIndex = 4;
            this.DeleteT.Text = "Delete";
            this.DeleteT.UseVisualStyleBackColor = false;
            this.DeleteT.Click += new System.EventHandler(this.DeleteT_Click);
            // 
            // UpdateT
            // 
            this.UpdateT.BackColor = System.Drawing.SystemColors.Desktop;
            this.UpdateT.Location = new System.Drawing.Point(187, 215);
            this.UpdateT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UpdateT.Name = "UpdateT";
            this.UpdateT.Size = new System.Drawing.Size(116, 48);
            this.UpdateT.TabIndex = 3;
            this.UpdateT.Text = "Update";
            this.UpdateT.UseVisualStyleBackColor = false;
            this.UpdateT.Click += new System.EventHandler(this.UpdateT_Click);
            // 
            // InsertT
            // 
            this.InsertT.BackColor = System.Drawing.SystemColors.InfoText;
            this.InsertT.Location = new System.Drawing.Point(8, 215);
            this.InsertT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InsertT.Name = "InsertT";
            this.InsertT.Size = new System.Drawing.Size(116, 47);
            this.InsertT.TabIndex = 2;
            this.InsertT.Text = "Insert";
            this.InsertT.UseVisualStyleBackColor = false;
            this.InsertT.Click += new System.EventHandler(this.InsertT_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Qualification";
            // 
            // txtAbilities
            // 
            this.txtAbilities.AutoSize = true;
            this.txtAbilities.Location = new System.Drawing.Point(40, 84);
            this.txtAbilities.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtAbilities.Name = "txtAbilities";
            this.txtAbilities.Size = new System.Drawing.Size(56, 17);
            this.txtAbilities.TabIndex = 0;
            this.txtAbilities.Text = "Abilities";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Technician Form";
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.SystemColors.Desktop;
            this.MainMenu.Location = new System.Drawing.Point(41, 497);
            this.MainMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(125, 54);
            this.MainMenu.TabIndex = 2;
            this.MainMenu.Text = "MainMenu";
            this.MainMenu.UseVisualStyleBackColor = false;
            this.MainMenu.Click += new System.EventHandler(this.MainMenu_Click);
            // 
            // Employee
            // 
            this.Employee.BackColor = System.Drawing.SystemColors.Desktop;
            this.Employee.Location = new System.Drawing.Point(229, 497);
            this.Employee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Employee.Name = "Employee";
            this.Employee.Size = new System.Drawing.Size(128, 53);
            this.Employee.TabIndex = 3;
            this.Employee.Text = "Employee";
            this.Employee.UseVisualStyleBackColor = false;
            this.Employee.Click += new System.EventHandler(this.Employee_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.Desktop;
            this.Exit.Location = new System.Drawing.Point(881, 497);
            this.Exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(148, 53);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Exits";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // btnNextForm
            // 
            this.btnNextForm.Location = new System.Drawing.Point(525, 412);
            this.btnNextForm.Name = "btnNextForm";
            this.btnNextForm.Size = new System.Drawing.Size(277, 117);
            this.btnNextForm.TabIndex = 5;
            this.btnNextForm.Text = "NEXT FROM";
            this.btnNextForm.UseVisualStyleBackColor = true;
            this.btnNextForm.Click += new System.EventHandler(this.btnNextForm_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnNextForm);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Employee);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Fuchsia;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form3";
            this.Text = "Technicain Form";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtq;
        private System.Windows.Forms.TextBox txtability;
        private System.Windows.Forms.Button DeleteT;
        private System.Windows.Forms.Button UpdateT;
        private System.Windows.Forms.Button InsertT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtAbilities;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MainMenu;
        private System.Windows.Forms.Button Employee;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button btnNextForm;
    }
}