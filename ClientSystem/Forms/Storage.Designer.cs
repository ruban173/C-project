namespace ClientSystem.Forms
{
    partial class Storage
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
            this.gridStorage = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.greenBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.blueBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.redBox = new System.Windows.Forms.TextBox();
            this.red = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.button_payment_card = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_category_goods = new System.Windows.Forms.Button();
            this.button_goods = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridStorage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridStorage
            // 
            this.gridStorage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridStorage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStorage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridStorage.Location = new System.Drawing.Point(3, 171);
            this.gridStorage.Name = "gridStorage";
            this.gridStorage.Size = new System.Drawing.Size(939, 322);
            this.gridStorage.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.button_add);
            this.groupBox1.Controls.Add(this.button_payment_card);
            this.groupBox1.Location = new System.Drawing.Point(3, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(637, 85);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Товар";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.greenBox);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.blueBox);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.redBox);
            this.groupBox3.Controls.Add(this.red);
            this.groupBox3.Location = new System.Drawing.Point(271, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(360, 54);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Критерии (Меньше)";
            // 
            // greenBox
            // 
            this.greenBox.Location = new System.Drawing.Point(251, 16);
            this.greenBox.Name = "greenBox";
            this.greenBox.Size = new System.Drawing.Size(46, 20);
            this.greenBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(225, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 4;
            // 
            // blueBox
            // 
            this.blueBox.Location = new System.Drawing.Point(150, 17);
            this.blueBox.Name = "blueBox";
            this.blueBox.Size = new System.Drawing.Size(46, 20);
            this.blueBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightBlue;
            this.label1.Location = new System.Drawing.Point(124, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 2;
            // 
            // redBox
            // 
            this.redBox.Location = new System.Drawing.Point(43, 18);
            this.redBox.Name = "redBox";
            this.redBox.Size = new System.Drawing.Size(46, 20);
            this.redBox.TabIndex = 1;
            // 
            // red
            // 
            this.red.BackColor = System.Drawing.Color.Red;
            this.red.Location = new System.Drawing.Point(17, 18);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(20, 20);
            this.red.TabIndex = 0;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(5, 19);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 36);
            this.button_add.TabIndex = 5;
            this.button_add.Text = "Анализ количества товара";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_payment_card
            // 
            this.button_payment_card.Location = new System.Drawing.Point(86, 19);
            this.button_payment_card.Name = "button_payment_card";
            this.button_payment_card.Size = new System.Drawing.Size(99, 36);
            this.button_payment_card.TabIndex = 7;
            this.button_payment_card.Text = "Анализ срока годности товара";
            this.button_payment_card.UseVisualStyleBackColor = true;
            this.button_payment_card.Click += new System.EventHandler(this.button_payment_card_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gridStorage, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(945, 496);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(939, 71);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_category_goods);
            this.groupBox2.Controls.Add(this.button_goods);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 64);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Управление";
            // 
            // button_category_goods
            // 
            this.button_category_goods.Location = new System.Drawing.Point(119, 19);
            this.button_category_goods.Name = "button_category_goods";
            this.button_category_goods.Size = new System.Drawing.Size(86, 39);
            this.button_category_goods.TabIndex = 1;
            this.button_category_goods.Text = "Категории";
            this.button_category_goods.UseVisualStyleBackColor = true;
            this.button_category_goods.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_goods
            // 
            this.button_goods.Location = new System.Drawing.Point(6, 19);
            this.button_goods.Name = "button_goods";
            this.button_goods.Size = new System.Drawing.Size(91, 39);
            this.button_goods.TabIndex = 0;
            this.button_goods.Text = "Товары";
            this.button_goods.UseVisualStyleBackColor = true;
            this.button_goods.Click += new System.EventHandler(this.button_goods_Click);
            // 
            // Storage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 496);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Storage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Склад";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Storage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridStorage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridStorage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox greenBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox blueBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox redBox;
        private System.Windows.Forms.Label red;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_payment_card;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_category_goods;
        private System.Windows.Forms.Button button_goods;
    }
}