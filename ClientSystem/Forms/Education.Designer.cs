namespace ClientSystem.Forms
{
    partial class Education
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.organization = new System.Windows.Forms.TextBox();
            this.date_create = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.qualification = new System.Windows.Forms.TextBox();
            this.specialty = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(174, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Тип";
            // 
            // type
            // 
            this.type.Location = new System.Drawing.Point(12, 31);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(285, 20);
            this.type.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Наименование учебного заведения";
            // 
            // organization
            // 
            this.organization.Location = new System.Drawing.Point(12, 78);
            this.organization.Name = "organization";
            this.organization.Size = new System.Drawing.Size(285, 20);
            this.organization.TabIndex = 5;
            // 
            // date_create
            // 
            this.date_create.Location = new System.Drawing.Point(12, 127);
            this.date_create.Name = "date_create";
            this.date_create.Size = new System.Drawing.Size(279, 20);
            this.date_create.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Дата рождения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Номер диплома";
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(12, 177);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(285, 20);
            this.number.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Присвоенная квалификация";
            // 
            // qualification
            // 
            this.qualification.Location = new System.Drawing.Point(12, 231);
            this.qualification.Name = "qualification";
            this.qualification.Size = new System.Drawing.Size(285, 20);
            this.qualification.TabIndex = 15;
            // 
            // specialty
            // 
            this.specialty.Location = new System.Drawing.Point(15, 284);
            this.specialty.Name = "specialty";
            this.specialty.Size = new System.Drawing.Size(285, 20);
            this.specialty.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Специальность";
            // 
            // Education
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 404);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.specialty);
            this.Controls.Add(this.qualification);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.number);
            this.Controls.Add(this.date_create);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.organization);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.type);
            this.Controls.Add(this.button1);
            this.Name = "Education";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Образование";
            this.Load += new System.EventHandler(this.Education_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox organization;
        private System.Windows.Forms.DateTimePicker date_create;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox qualification;
        private System.Windows.Forms.TextBox specialty;
        private System.Windows.Forms.Label label6;
    }
}