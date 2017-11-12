namespace ClientSystem.Forms
{
    partial class AddCategoryGoods
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gridCategoryGoods = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.group = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Clear = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.titleCategory = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCategoryGoods)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.group.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.64968F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.35032F));
            this.tableLayoutPanel1.Controls.Add(this.gridCategoryGoods, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(785, 357);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gridCategoryGoods
            // 
            this.gridCategoryGoods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCategoryGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCategoryGoods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCategoryGoods.Location = new System.Drawing.Point(3, 3);
            this.gridCategoryGoods.Name = "gridCategoryGoods";
            this.gridCategoryGoods.Size = new System.Drawing.Size(422, 351);
            this.gridCategoryGoods.TabIndex = 0;
            this.gridCategoryGoods.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCategoryGoods_CellClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.group, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(431, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.37892F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.62109F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(351, 351);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // group
            // 
            this.group.Controls.Add(this.titleCategory);
            this.group.Dock = System.Windows.Forms.DockStyle.Fill;
            this.group.Location = new System.Drawing.Point(3, 64);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(345, 284);
            this.group.TabIndex = 0;
            this.group.TabStop = false;
            this.group.Text = "Информация";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Clear);
            this.flowLayoutPanel1.Controls.Add(this.Add);
            this.flowLayoutPanel1.Controls.Add(this.save);
            this.flowLayoutPanel1.Controls.Add(this.delete);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(345, 55);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(3, 3);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(80, 33);
            this.Clear.TabIndex = 0;
            this.Clear.Text = "Очистить";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(89, 3);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(80, 33);
            this.Add.TabIndex = 1;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(175, 3);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(80, 33);
            this.save.TabIndex = 2;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(261, 3);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(80, 33);
            this.delete.TabIndex = 3;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // titleCategory
            // 
            this.titleCategory.Location = new System.Drawing.Point(3, 30);
            this.titleCategory.Name = "titleCategory";
            this.titleCategory.Size = new System.Drawing.Size(323, 20);
            this.titleCategory.TabIndex = 0;
            // 
            // AddCategoryGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 357);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddCategoryGoods";
            this.Text = "Управление категориями товаров";
            this.Load += new System.EventHandler(this.AddCategoryGoods_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCategoryGoods)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.group.ResumeLayout(false);
            this.group.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView gridCategoryGoods;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox group;
        private System.Windows.Forms.TextBox titleCategory;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button delete;
    }
}