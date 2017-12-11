namespace ClientSystem.Forms
{
    partial class AdminSaleOrder
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
            this.begin = new System.Windows.Forms.DateTimePicker();
            this.end = new System.Windows.Forms.DateTimePicker();
            this.interval = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.allEmp = new System.Windows.Forms.CheckBox();
            this.allGoods = new System.Windows.Forms.CheckBox();
            this.Товары = new System.Windows.Forms.Label();
            this.listEmp = new System.Windows.Forms.CheckedListBox();
            this.listGoods = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(355, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Сформировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // begin
            // 
            this.begin.Location = new System.Drawing.Point(32, 22);
            this.begin.Name = "begin";
            this.begin.Size = new System.Drawing.Size(149, 20);
            this.begin.TabIndex = 1;
            // 
            // end
            // 
            this.end.Enabled = false;
            this.end.Location = new System.Drawing.Point(223, 22);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(159, 20);
            this.end.TabIndex = 1;
            // 
            // interval
            // 
            this.interval.AutoSize = true;
            this.interval.Location = new System.Drawing.Point(411, 24);
            this.interval.Name = "interval";
            this.interval.Size = new System.Drawing.Size(75, 17);
            this.interval.TabIndex = 2;
            this.interval.Text = "Интервал";
            this.interval.UseVisualStyleBackColor = true;
            this.interval.CheckedChanged += new System.EventHandler(this.interval_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "С";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ПО";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Сотрудник(и)";
            // 
            // allEmp
            // 
            this.allEmp.AutoSize = true;
            this.allEmp.Checked = true;
            this.allEmp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.allEmp.Location = new System.Drawing.Point(97, 59);
            this.allEmp.Name = "allEmp";
            this.allEmp.Size = new System.Drawing.Size(45, 17);
            this.allEmp.TabIndex = 2;
            this.allEmp.Text = "Все";
            this.allEmp.UseVisualStyleBackColor = true;
            this.allEmp.CheckedChanged += new System.EventHandler(this.allEmp_CheckedChanged);
            // 
            // allGoods
            // 
            this.allGoods.AutoSize = true;
            this.allGoods.Checked = true;
            this.allGoods.CheckState = System.Windows.Forms.CheckState.Checked;
            this.allGoods.Location = new System.Drawing.Point(337, 59);
            this.allGoods.Name = "allGoods";
            this.allGoods.Size = new System.Drawing.Size(45, 17);
            this.allGoods.TabIndex = 2;
            this.allGoods.Text = "Все";
            this.allGoods.UseVisualStyleBackColor = true;
            this.allGoods.CheckedChanged += new System.EventHandler(this.allGoods_CheckedChanged);
            // 
            // Товары
            // 
            this.Товары.AutoSize = true;
            this.Товары.Location = new System.Drawing.Point(263, 59);
            this.Товары.Name = "Товары";
            this.Товары.Size = new System.Drawing.Size(55, 13);
            this.Товары.TabIndex = 4;
            this.Товары.Text = "Товар (ы)";
            // 
            // listEmp
            // 
            this.listEmp.FormattingEnabled = true;
            this.listEmp.Location = new System.Drawing.Point(12, 85);
            this.listEmp.Name = "listEmp";
            this.listEmp.Size = new System.Drawing.Size(205, 169);
            this.listEmp.TabIndex = 6;
            // 
            // listGoods
            // 
            this.listGoods.FormattingEnabled = true;
            this.listGoods.Location = new System.Drawing.Point(248, 85);
            this.listGoods.Name = "listGoods";
            this.listGoods.Size = new System.Drawing.Size(224, 169);
            this.listGoods.TabIndex = 6;
            // 
            // AdminSaleOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 321);
            this.Controls.Add(this.listGoods);
            this.Controls.Add(this.listEmp);
            this.Controls.Add(this.Товары);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.allGoods);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.allEmp);
            this.Controls.Add(this.interval);
            this.Controls.Add(this.end);
            this.Controls.Add(this.begin);
            this.Controls.Add(this.button1);
            this.Name = "AdminSaleOrder";
            this.Text = "Параметры отчета продаж";
            this.Load += new System.EventHandler(this.AdminSaleOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker begin;
        private System.Windows.Forms.DateTimePicker end;
        private System.Windows.Forms.CheckBox interval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox allEmp;
        private System.Windows.Forms.CheckBox allGoods;
        private System.Windows.Forms.Label Товары;
        private System.Windows.Forms.CheckedListBox listEmp;
        private System.Windows.Forms.CheckedListBox listGoods;
    }
}