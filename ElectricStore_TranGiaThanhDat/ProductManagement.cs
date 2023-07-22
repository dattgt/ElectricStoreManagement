using Services.Models;
using Services.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectricStore_TranGiaThanhDat
{
    public partial class ProductManagement : Form
    {
        ProductRepository _productRepository;
        Product _product;
        CategoryRepository _categoryRepository;

        public ProductManagement()
        {
            InitializeComponent();
            txtID.Enabled = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            _productRepository = new ProductRepository();
            _categoryRepository = new CategoryRepository();
            loadCombo();
            loadData();
        }

        private void loadData()
        {
            var listProduct = new ProductRepository().GetAll().Select(p => new
            {
                p.Id,
                p.ProductName,
                p.ProductCode,
                p.Price,
                p.DateCreate,
                p.CategoryId
            });
            dgv.DataSource = new BindingSource() { DataSource = listProduct };
        }

        private void loadCombo()
        {
            var listCombo = _categoryRepository.GetAll().
                Select(p => new { p.Id, p.CategoryName }).ToList();
            cbb.DisplayMember = "CategoryName";
            cbb.ValueMember = "Id";
            cbb.DataSource = listCombo;
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Enabled = false;
            dtpProduct.Enabled = false;
            _product = _productRepository.GetAll().Where(p =>
            p.Id.Equals(dgv.Rows[e.RowIndex].Cells[0].Value)).FirstOrDefault();

            txtID.Text = _product.Id.ToString();
            txtProductName.Text = _product.ProductName;
            txtProductCode.Text = _product.ProductCode.Trim();
            txtPrice.Text = _product.Price.ToString();
            dtpProduct.Value = _product.DateCreate.Value;
            cbb.SelectedValue = _product.CategoryId;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var search = new ProductRepository().GetAll().Where(p =>
            p.ProductCode.Contains(txtSearch.Text)).Select(p => new
            {
                p.Id,
                p.ProductName,
                p.ProductCode,
                p.Price,
                p.DateCreate,
                p.CategoryId
            });
            dgv.DataSource = new BindingSource() { DataSource = search };
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to want delete this product?", "Notification System",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                _productRepository.Delete(_product);
                MessageBox.Show("Delete Successfully!!!", "Notification System", MessageBoxButtons.OK);
                loadData();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var _product = checkInput();

            if (_product != null)
            {
                _productRepository.Create(_product);
                MessageBox.Show("Add Successfully!!!", "Notification System", MessageBoxButtons.OK);
                loadData();
            }
        }

        private Product checkInput()
        {
            Product product = new Product();
            String ProductName = txtProductName.Text.Trim();
            String ProductCode = txtProductCode.Text.Trim();
            String ProductPrice = txtPrice.Text.Trim();

            if (String.IsNullOrEmpty(ProductName)
                || String.IsNullOrEmpty(ProductCode) || String.IsNullOrEmpty(ProductPrice))
            {
                MessageBox.Show("You must input full information!", "Notification System",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }


            product.ProductName = ProductName;

            if (txtProductCode.Text.Length != 4)
            {
                MessageBox.Show("Product Code must have 4 characters", "Notification System",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
            product.ProductCode = ProductCode.ToUpper();

            decimal price = decimal.Parse(ProductPrice);
            if (price <= 0)
            {
                MessageBox.Show("Product Price must be > 0", "Notification System",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
            product.Price = price;

            product.DateCreate = dtpProduct.Value;
            product.CategoryId = int.Parse(cbb.SelectedValue.ToString());


            return product;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var product = checkInput();
            String id = txtID.Text;
            if (product != null)
            {
                var listProduct = _productRepository.GetAll().
                    Where(p => p.Id == int.Parse(txtID.Text)).FirstOrDefault();
                listProduct.ProductName = product.ProductName;
                listProduct.ProductCode = product.ProductCode;
                listProduct.Price = product.Price;
                listProduct.DateCreate = product.DateCreate;
                listProduct.CategoryId = product.CategoryId;
                _productRepository.Update(listProduct);
                MessageBox.Show("Update Successfully!!!", "Notification System", MessageBoxButtons.OK);
                loadData();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtProductName.Text = "";
            txtProductCode.Text = "";
            txtPrice.Text = "";
            dtpProduct.Value = DateTime.Now;
            cbb.SelectedIndex = 0;
        }
    }
}
