using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WatchShopDAL;

using System.Data.Entity;

namespace WatchShopFormsApp
{
    public partial class CartForm : Form
    {
        List<Product> productList;
        public CartForm(List<Product> list)
        {
            InitializeComponent();

            productList = list;

            // init table
            InitTable();

            // button listener
            buttonCheckOut.Click += OnCheckout;

            buttonRemove.Click += OnRemove;
        }

        private void OnRemove(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridViewProduct.SelectedRows)
            {
                dataGridViewProduct.Rows.RemoveAt(item.Index);
            }          

        }

        private void OnCheckout(object sender, EventArgs e)
        {
            Console.WriteLine(productList.Count());
        }

        private void InitTable()
        {
            dataGridViewProduct.DataSource = new BindingList<Product>(productList);
            dataGridViewProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProduct.AllowUserToAddRows = false;
            dataGridViewProduct.Columns["Id"].ReadOnly = true;
            dataGridViewProduct.Columns["Quantity"].ReadOnly = false;
            dataGridViewProduct.Columns["Brand"].ReadOnly = true;
            dataGridViewProduct.Columns["Description"].ReadOnly = true;
            dataGridViewProduct.Columns["Price"].ReadOnly = true;
                       
        }
    }
}
