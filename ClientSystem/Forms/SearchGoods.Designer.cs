namespace ClientSystem.Forms
{
    partial class SearchGoods
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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupGoods = new System.Windows.Forms.GroupBox();
            this.basket = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.Clear = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lab1 = new System.Windows.Forms.Label();
            this.gridCategoryGoods = new System.Windows.Forms.DataGridView();
            this.gridGoods = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupGoods.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCategoryGoods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGoods)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.64968F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 238F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(941, 453);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.groupGoods, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel3, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(706, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.75168F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.24832F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(232, 447);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // groupGoods
            // 
            this.groupGoods.Controls.Add(this.basket);
            this.groupGoods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupGoods.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupGoods.Location = new System.Drawing.Point(3, 60);
            this.groupGoods.Name = "groupGoods";
            this.groupGoods.Padding = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.groupGoods.Size = new System.Drawing.Size(226, 384);
            this.groupGoods.TabIndex = 0;
            this.groupGoods.TabStop = false;
            this.groupGoods.Text = "Товары в корзину";
            // 
            // basket
            // 
            this.basket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.basket.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.basket.FormattingEnabled = true;
            this.basket.ItemHeight = 18;
            this.basket.Location = new System.Drawing.Point(3, 28);
            this.basket.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.basket.Name = "basket";
            this.basket.Size = new System.Drawing.Size(220, 353);
            this.basket.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.Clear);
            this.flowLayoutPanel3.Controls.Add(this.Add);
            this.flowLayoutPanel3.Controls.Add(this.delete);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(226, 51);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(3, 3);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(68, 33);
            this.Clear.TabIndex = 0;
            this.Clear.Text = "Очистить";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(77, 3);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(68, 33);
            this.Add.TabIndex = 1;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(151, 3);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(70, 33);
            this.delete.TabIndex = 3;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.70992F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.29008F));
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.gridCategoryGoods, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.gridGoods, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.086614F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.91338F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(697, 447);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.flowLayoutPanel2.Controls.Add(this.lab1);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(326, 25);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lab1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab1.Location = new System.Drawing.Point(3, 0);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(220, 24);
            this.lab1.TabIndex = 0;
            this.lab1.Text = "КАТЕГОРИИ ТОВАРОВ";
            // 
            // gridCategoryGoods
            // 
            this.gridCategoryGoods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCategoryGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCategoryGoods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCategoryGoods.Location = new System.Drawing.Point(3, 34);
            this.gridCategoryGoods.Name = "gridCategoryGoods";
            this.gridCategoryGoods.Size = new System.Drawing.Size(326, 410);
            this.gridCategoryGoods.TabIndex = 0;
            this.gridCategoryGoods.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCategoryGoods_CellClick);
            // 
            // gridGoods
            // 
            this.gridGoods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridGoods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridGoods.Location = new System.Drawing.Point(335, 34);
            this.gridGoods.Name = "gridGoods";
            this.gridGoods.Size = new System.Drawing.Size(359, 410);
            this.gridGoods.TabIndex = 1;
            this.gridGoods.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridGoods_CellClick);
            this.gridGoods.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridGoods_CellDoubleClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(335, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(359, 25);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ТОВАРЫ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 453);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SearchGoods";
            this.Text = "Управление  товарами";
            this.Load += new System.EventHandler(this.SearchGoods_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupGoods.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCategoryGoods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGoods)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.DataGridView gridCategoryGoods;
        private System.Windows.Forms.DataGridView gridGoods;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupGoods;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.ListBox basket;
        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.Label label1;
    }
}