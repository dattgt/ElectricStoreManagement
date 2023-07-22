namespace ElectricStore_TranGiaThanhDat
{
    partial class ProductManagement
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
            dgv = new DataGridView();
            groupBox1 = new GroupBox();
            txtSearch = new TextBox();
            label1 = new Label();
            btnDelete = new Button();
            btnAdd = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtID = new TextBox();
            txtProductName = new TextBox();
            txtProductCode = new TextBox();
            txtPrice = new TextBox();
            dtpProduct = new DateTimePicker();
            btnUpdate = new Button();
            cbb = new ComboBox();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(12, 175);
            dgv.Name = "dgv";
            dgv.RowTemplate.Height = 25;
            dgv.Size = new Size(654, 392);
            dgv.TabIndex = 0;
            dgv.CellDoubleClick += dgv_CellDoubleClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 111);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(313, 46);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search Product by Product Code";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(14, 20);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(282, 23);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Myanmar Text", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(348, 24);
            label1.Name = "label1";
            label1.Size = new Size(350, 56);
            label1.TabIndex = 18;
            label1.Text = "Product Management";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(798, 476);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(91, 43);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(686, 476);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(91, 43);
            btnAdd.TabIndex = 20;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(697, 193);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 21;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(697, 239);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 22;
            label3.Text = "Product Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(697, 379);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 23;
            label4.Text = "Date Create";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(697, 291);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 23;
            label5.Text = "Product Code";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(697, 334);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 24;
            label6.Text = "Price";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(697, 429);
            label7.Name = "label7";
            label7.Size = new Size(90, 15);
            label7.TabIndex = 25;
            label7.Text = "Category Name";
            // 
            // txtID
            // 
            txtID.Location = new Point(807, 190);
            txtID.Name = "txtID";
            txtID.Size = new Size(115, 23);
            txtID.TabIndex = 26;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(807, 236);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(115, 23);
            txtProductName.TabIndex = 27;
            // 
            // txtProductCode
            // 
            txtProductCode.Location = new Point(807, 288);
            txtProductCode.Name = "txtProductCode";
            txtProductCode.Size = new Size(115, 23);
            txtProductCode.TabIndex = 28;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(807, 331);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(115, 23);
            txtPrice.TabIndex = 29;
            // 
            // dtpProduct
            // 
            dtpProduct.Location = new Point(807, 379);
            dtpProduct.Name = "dtpProduct";
            dtpProduct.Size = new Size(200, 23);
            dtpProduct.TabIndex = 32;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(906, 476);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(91, 43);
            btnUpdate.TabIndex = 33;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // cbb
            // 
            cbb.FormattingEnabled = true;
            cbb.Location = new Point(807, 429);
            cbb.Name = "cbb";
            cbb.Size = new Size(121, 23);
            cbb.TabIndex = 34;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(1009, 476);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(91, 43);
            btnRefresh.TabIndex = 35;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // ProductManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 682);
            Controls.Add(btnRefresh);
            Controls.Add(cbb);
            Controls.Add(btnUpdate);
            Controls.Add(dtpProduct);
            Controls.Add(txtPrice);
            Controls.Add(txtProductCode);
            Controls.Add(txtProductName);
            Controls.Add(txtID);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(dgv);
            Name = "ProductManagement";
            Text = "ProductManagement";
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv;
        private GroupBox groupBox1;
        private TextBox txtSearch;
        private Label label1;
        private Button btnDelete;
        private Button btnAdd;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtID;
        private TextBox txtProductName;
        private TextBox txtProductCode;
        private TextBox txtPrice;
        private DateTimePicker dtpProduct;
        private Button btnUpdate;
        private ComboBox cbb;
        private Button btnRefresh;
    }
}