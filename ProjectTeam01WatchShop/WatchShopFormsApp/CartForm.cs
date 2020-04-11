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
        WatchShopEntities context;
        List<Product> productList;
        List<Employee> employeeList;
        Employee selectedEmployee;
        Transaction transaction;
        List<Order> orderList;
        public CartForm(WatchShopEntities c, ref List<Product> list)
        {
            InitializeComponent();

            productList = list;

            context = c;

            // init table
            InitTable();

            // init list
            InitList();

            // button listener
            buttonCheckOut.Click += OnCheckout;

            buttonRemove.Click += OnRemove;

            // dropdown listener
            comboBoxSaler.SelectedIndexChanged += (s, e) =>
            {
                int index = comboBoxSaler.SelectedIndex;
                Console.WriteLine(index);
                selectedEmployee = employeeList[index];
            };
        }
        /// <summary>
        /// initialize list of employee
        /// </summary>
        private void InitList()
        {
            employeeList = context.Employees.Local.ToList();
            comboBoxSaler.Items.AddRange(employeeList.Select(x => x.Name).ToArray());
        }

        /// <summary>
        /// render total text
        /// </summary>
        private void renderText()
        {
            decimal subTotal = 0;
            decimal taxTotal = 0;
            decimal total = 0;
            foreach (Product item in productList)
            {
                subTotal += item.Quantity * item.Price;
            }
            taxTotal = subTotal * 10 / 100;
            total = subTotal + taxTotal;

            labelSubTotal.Text = subTotal.ToString("C2");
            labelTaxTotal.Text = taxTotal.ToString("C2");
            labelTotal.Text = total.ToString("C2");
        }

        /// <summary>
        /// on remove product
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnRemove(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridViewProduct.SelectedRows)
            {
                dataGridViewProduct.Rows.RemoveAt(item.Index);
            }

            if (productList.Count == 0)
            {
                MessageBox.Show("The cart is empty");
                Close();
            }

            renderText();

        }
        /// <summary>
        /// on checkout to generate receipt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCheckout(object sender, EventArgs e)
        {

            if (selectedEmployee == null)
            {
                MessageBox.Show("Saler cannot be empty");
                return;
            }

            if (textBoxCustomer.Text.ToString().Equals(""))
            {
                MessageBox.Show("Customer Email cannot be empty");
                return;
            }

            // create transaction
            transaction = new Transaction();
            transaction.CustomerEmail = textBoxCustomer.Text.ToString();
            transaction.EmpCashierID = selectedEmployee.Id;
            transaction.SubTotal = 0;
            transaction.TaxAmount = 0;
            transaction.TotalAmount = 0;
            context.Transactions.Add(transaction);
            context.SaveChanges();

            // create orders
            orderList = new List<Order>();

            decimal subTotal = 0;
            decimal taxTotal = 0;
            decimal total = 0;

            foreach (Product item in productList)
            {
                Order order = new Order();
                order.TransactionId = transaction.Id;
                order.ProductId = item.Id;
                order.SalerId = selectedEmployee.Id;
                order.Quantity = item.Quantity;
                context.Orders.Add(order);
                context.SaveChanges();
                orderList.Add(order);
                subTotal += item.Quantity * item.Price;

                // update product quantity
                Product p = context.Products.Local.ToList().Where(x => x.Id == item.Id).FirstOrDefault();
                p.Quantity = p.Quantity - item.Quantity;
                context.SaveChanges();
            }

            taxTotal = subTotal * 10 / 100;
            total = subTotal + taxTotal;

            // update transaction
            transaction.SubTotal = subTotal;
            transaction.TaxAmount = taxTotal;
            transaction.TotalAmount = total;
            context.SaveChanges();

            dataGridViewProduct.Rows.Clear();
            MessageBox.Show("Check out is successful");

            Close();

        }
        /// <summary>
        /// initialize table
        /// </summary>
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

            dataGridViewProduct.CellValueChanged += (s, e) =>
            {
                renderText();
            };

            renderText();
        }
    }
}
