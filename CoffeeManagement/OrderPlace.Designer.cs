namespace CoffeeManagement
{
    partial class OrderPlace
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
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.Total = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lstItem = new System.Windows.Forms.ListView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.colCoffee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Place Order";
            // 
            // dgvCart
            // 
            this.dgvCart.ColumnHeadersHeight = 34;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCoffee,
            this.colUnit,
            this.colQuan,
            this.colPrice});
            this.dgvCart.Location = new System.Drawing.Point(434, 255);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.RowHeadersWidth = 62;
            this.dgvCart.RowTemplate.Height = 28;
            this.dgvCart.Size = new System.Drawing.Size(579, 260);
            this.dgvCart.TabIndex = 15;
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(623, 536);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(44, 20);
            this.Total.TabIndex = 16;
            this.Total.Text = "Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(590, 566);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 46);
            this.label7.TabIndex = 17;
            this.label7.Text = "0.00 $";
            // 
            // btnPay
            // 
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnPay.Location = new System.Drawing.Point(852, 525);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(132, 42);
            this.btnPay.TabIndex = 18;
            this.btnPay.Text = "Payment";
            this.btnPay.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnRemove.Location = new System.Drawing.Point(425, 521);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(127, 42);
            this.btnRemove.TabIndex = 19;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Category";
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(153, 119);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(143, 28);
            this.cbCategory.TabIndex = 21;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // lstItem
            // 
            this.lstItem.HideSelection = false;
            this.lstItem.Location = new System.Drawing.Point(153, 268);
            this.lstItem.Name = "lstItem";
            this.lstItem.Size = new System.Drawing.Size(143, 232);
            this.lstItem.TabIndex = 23;
            this.lstItem.UseCompatibleStateImageBehavior = false;
            this.lstItem.View = System.Windows.Forms.View.List;
            this.lstItem.SelectedIndexChanged += new System.EventHandler(this.lstItem_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(153, 207);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(143, 26);
            this.txtSearch.TabIndex = 22;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(451, 65);
            this.txtItem.Multiline = true;
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(190, 46);
            this.txtItem.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(511, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Item";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(770, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(727, 65);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(158, 46);
            this.txtPrice.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(495, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Quantity";
            // 
            // txtQuan
            // 
            this.txtQuan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuan.Location = new System.Drawing.Point(488, 155);
            this.txtQuan.Multiline = true;
            this.txtQuan.Name = "txtQuan";
            this.txtQuan.Size = new System.Drawing.Size(112, 46);
            this.txtQuan.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(770, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(727, 155);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(158, 44);
            this.txtTotal.TabIndex = 30;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnAdd.Location = new System.Drawing.Point(805, 207);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(127, 42);
            this.btnAdd.TabIndex = 32;
            this.btnAdd.Text = "Add To Cart";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(149, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 33;
            this.label8.Text = "Search";
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(598, 155);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(43, 46);
            this.btnPlus.TabIndex = 34;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(451, 155);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(42, 46);
            this.btnMinus.TabIndex = 35;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // colCoffee
            // 
            this.colCoffee.HeaderText = "Item";
            this.colCoffee.MinimumWidth = 8;
            this.colCoffee.Name = "colCoffee";
            this.colCoffee.Width = 80;
            // 
            // colUnit
            // 
            this.colUnit.HeaderText = "UnitPrice";
            this.colUnit.MinimumWidth = 8;
            this.colUnit.Name = "colUnit";
            this.colUnit.Width = 80;
            // 
            // colQuan
            // 
            this.colQuan.HeaderText = "Quantity";
            this.colQuan.MinimumWidth = 8;
            this.colQuan.Name = "colQuan";
            this.colQuan.Width = 80;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Price";
            this.colPrice.MinimumWidth = 8;
            this.colPrice.Name = "colPrice";
            this.colPrice.Width = 80;
            // 
            // OrderPlace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 643);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtQuan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.lstItem);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.dgvCart);
            this.Controls.Add(this.label1);
            this.Name = "OrderPlace";
            this.Text = "OrderPlace";
            this.Load += new System.EventHandler(this.OrderPlace_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ListView lstItem;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQuan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCoffee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
    }
}