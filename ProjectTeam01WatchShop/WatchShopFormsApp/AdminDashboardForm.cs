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
    public partial class AdminDashboardForm : Form
    {
        private WatchShopEntities context;
        private Product selectedProduct;
        private BindingList<Product> list;
        public AdminDashboardForm(WatchShopEntities context)
        {
            InitializeComponent();
            this.context = context;

            // init table
            InitTable();

            // button listener
            buttonNew.Click += OnNew;
            buttonSave.Click += OnSave;

        }

        private void OnSave(object sender, EventArgs e)
        {
            if (dataGridViewProduct.SelectedRows.Count > 0)
            {
                // edit
                if (textBoxBranch.Text.Equals(""))
                {
                    MessageBox.Show("Branch cannot be empty");
                }
                else
                {
                    Product product = list
                        .Where(x => x.Id == int.Parse(dataGridViewProduct.SelectedRows[0].Cells[0].Value.ToString()))
                        .FirstOrDefault();
                    product.Brand = textBoxBranch.Text;
                    product.Description = textBoxDescription.Text;
                    product.Quantity = int.Parse(numericUpDownQuantity.Value.ToString());
                    product.Price = decimal.Parse(numericUpDownPrice.Value.ToString());
                    context.SaveChanges();
                    dataGridViewProduct.Refresh();
                }
            }
            else
            {
                // new
                if (textBoxBranch.Text.Equals(""))
                {
                    MessageBox.Show("Branch cannot be empty");
                }
                else
                {
                    Product product = new Product();
                    product.Brand = textBoxBranch.Text;
                    product.Description = textBoxDescription.Text;
                    product.Quantity = int.Parse(numericUpDownQuantity.Value.ToString());
                    product.Price = decimal.Parse(numericUpDownPrice.Value.ToString());
                    context.Products.Local.Add(product);
                    context.SaveChanges();
                }
            }
        }

        private void OnNew(object sender, EventArgs e)
        {
            labelId.Text = "[new]";
            textBoxBranch.Clear();
            textBoxDescription.Clear();
            numericUpDownQuantity.Value = 0;
            numericUpDownPrice.Value = 0;

            dataGridViewProduct.ClearSelection();
        }

        /// <summary>
        /// initialize table
        /// </summary>
        private void InitTable()
        {
            list = context.Products.Local.ToBindingList();
            dataGridViewProduct.DataSource = list;            
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

                labelId.Text = selectedProduct.Id.ToString();
                textBoxBranch.Text = selectedProduct.Brand;
                textBoxDescription.Text = selectedProduct.Description;
                numericUpDownQuantity.Value = decimal.Parse(selectedProduct.Quantity.ToString());
                numericUpDownPrice.Value = decimal.Parse(selectedProduct.Price.ToString());

            }

        }
    }
}
