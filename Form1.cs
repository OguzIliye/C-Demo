﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductDal _productDal = new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product 
            {
                Name=txtName.Text,
                UnitPrice=Convert.ToDecimal(txtUnitPrice.Text),
                StrockAmount=Convert.ToInt32(txtStockAmount.Text)
            });
            LoadProducts();
            MessageBox.Show("Product Added");
        }

        private void dgwProperties_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNameUpdate.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            txtUnitPriceUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            txtStockAmountUpdate.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                Name= txtNameUpdate.Text,
                UnitPrice= Convert.ToDecimal(txtUnitPriceUpdate.Text),
                StrockAmount= Convert.ToInt32(txtStockAmountUpdate.Text)
            };
            _productDal.Update(product);
            LoadProducts();
            MessageBox.Show("Updated");
        }
    }
}
