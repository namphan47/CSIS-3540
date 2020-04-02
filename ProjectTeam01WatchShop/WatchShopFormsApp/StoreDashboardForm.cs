using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using WatchShopDAL;

namespace WatchShopFormsApp
{
    public partial class StoreDashboardForm : Form
    {
        private WatchShopEntities context;
        private Product selectedProduct;
        private List<Product> selectedProductList = new List<Product>();
        private CartForm cartForm;
        public StoreDashboardForm(WatchShopEntities context)
        {
            InitializeComponent();
            this.context = context;

            // init table
            InitTable();

            // button listener

            buttonViewCart.Click += (s, e) =>
            {
                cartForm = new CartForm(selectedProductList);
                cartForm.Show();
            };

            buttonAddToCart.Click += OnAddToCart;


        }
        /// <summary>
        /// initialize table
        /// </summary>
        private void InitTable()
        {
            dataGridViewProduct.DataSource = context.Products.Local.ToBindingList();
            dataGridViewProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProduct.MultiSelect = false;
            dataGridViewProduct.ReadOnly = true;
            dataGridViewProduct.AllowUserToAddRows = false;

            dataGridViewProduct.SelectionChanged -= OnRowChange;
            dataGridViewProduct.SelectionChanged += OnRowChange;
        }

        /// <summary>
        /// listener when row change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnRowChange(object sender, EventArgs e)
        {
            if (dataGridViewProduct.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewProduct.SelectedRows[0];
                long id = long.Parse(row.Cells[0].Value.ToString());

                selectedProduct = context.Products.Local.ToList().Where(x => x.Id == id).FirstOrDefault();
                labelBranch.Text = selectedProduct.Brand;
                labelDescription.Text = selectedProduct.Description;
                labelPrice.Text = selectedProduct.Price.ToString();

            }

        }

        private void OnAddToCart(object sender, EventArgs e)
        {
            if (selectedProduct != null)
            {
                // check existing in cart
                Product foundP = selectedProductList.Where(x => x.Id == selectedProduct.Id).FirstOrDefault();
                if (foundP != null)
                {
                    if (foundP.Quantity + int.Parse(numericUpDownQuantity.Value.ToString()) > selectedProduct.Quantity)
                    {
                        MessageBox.Show("Stock is limited");
                        return;
                    }
                    foundP.Quantity += int.Parse(numericUpDownQuantity.Value.ToString());
                }
                else
                {
                    if (int.Parse(numericUpDownQuantity.Value.ToString()) > selectedProduct.Quantity)
                    {
                        MessageBox.Show("Stock is limited");
                        return;
                    }
                    Product product = new Product();
                    product.Id = selectedProduct.Id;
                    product.Brand = selectedProduct.Brand;
                    product.Description = selectedProduct.Description;
                    product.Price = selectedProduct.Price;
                    product.Quantity = int.Parse(numericUpDownQuantity.Value.ToString());
                    selectedProductList.Add(product);

                    numericUpDownQuantity.Value = 1;
                }

                labelIncart.Text = selectedProductList.Count + "";

            }
            else
            {
                MessageBox.Show("No product is selected");
            }
        }
    }
}
