﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WatchShopDAL;

namespace WatchShopFormsApp
{
    public partial class SalesReport : Form
    {
        private WatchShopEntities context;
        private List<OrdersDetails> orderDetailsList = new List<OrdersDetails>();
        public SalesReport(WatchShopEntities context)
        {
            InitializeComponent();
            this.context = context;
            InititializeDataGridView();
            GetDataFromDB();
            InitializeList();
            ResetControlsToDefault();
            DisplaySalesReport();
            resetButton.Click += ResetButton_Click;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ResetControlsToDefault();
        }

        private void GetDataFromDB()
        {
            context.Transactions.Load();
            context.Orders.Load();
            var studentRegistrations =
                 (from Transaction in context.Transactions
                  from Order in Transaction.Orders
                  select new OrdersDetails
                  {
                      TransactionID = Transaction.Id,
                      SellerName = Order.Employee.Name,
                      Quantity = Order.Quantity,
                      ProductName = Order.Product.Brand,
                      ProductPrice = Order.Product.Price,
                  });
            orderDetailsList = studentRegistrations.ToList();
        }
        private void InititializeDataGridView()
        {
           
            salesReportDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            salesReportDataGridView.AllowUserToAddRows = false;
            salesReportDataGridView.ReadOnly = true;
            salesReportDataGridView.RowHeadersVisible = false;

            salesReportDataGridView.AllowUserToDeleteRows = false;

            salesReportDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            salesReportDataGridView.RowHeadersVisible = false;
            salesReportDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            salesReportDataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


            salesReportDataGridView.Columns.Clear();
        }
       
        private void ResetControlsToDefault()
        {

            totalAmountProductsTextBox.Clear();
            totalTransactionsTextBox.Clear();
            totalAmountProductsTextBox.Clear();

            resetListView(empNameListBox);
            resetListView(brandNameListBox);

            DisplaySalesReport();

        }

        private void resetListView(ListBox listBox)
        {
            listBox.SelectedIndexChanged -= ListBox_SelectedIndexChanged;
            for (int i = 0; i < listBox.Items.Count; i++)
                listBox.SetSelected(i, true);
            listBox.SelectedIndexChanged += ListBox_SelectedIndexChanged;
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplaySalesReport();
        }

        private void DisplaySalesReport()
        {
            List<String> employeeNameList = new List<String>();
            List<String> brandNamesList = new List<string>();
            getSelectedFilterList(empNameListBox, employeeNameList);
            getSelectedFilterList(brandNameListBox, brandNamesList);
            var orderDetailsDataList = from OrdersDetails in orderDetailsList
                                       join employeeName in employeeNameList on OrdersDetails.SellerName equals employeeName
                                       join brandName in brandNamesList on OrdersDetails.ProductName equals brandName
                                       orderby employeeName
                                       select OrdersDetails;
            salesReportDataGridView.DataSource = orderDetailsDataList.ToList();
            var totalTransactions = 0;
            var totalProductPrice = 0.0M;
            var totalQuantitySold = 0;
            if (orderDetailsDataList.Count() > 0)
            {
                totalTransactions = orderDetailsDataList.Select(t => t.TransactionID).Distinct().Count();
                totalProductPrice = orderDetailsDataList.Select(p => p.ProductPrice).Sum();
                totalQuantitySold = orderDetailsDataList.Select(q => q.Quantity).Sum();
            }
            totalTransactionsTextBox.Text = totalTransactions.ToString();
            totalAmountProductsTextBox.Text = totalProductPrice.ToString();
            totalQuantityTextBox.Text = totalQuantitySold.ToString();

        }

        private void getSelectedFilterList(ListBox selectedListBox, List<String> filterList)
        {
            for (int index = 0; index < selectedListBox.SelectedItems.Count; index++)
            {
                filterList.Add(selectedListBox.SelectedItems[index].ToString());
            }
        }
        private void InitializeList()
        {
            empNameListBox.Items.Clear();
            empNameListBox.SelectionMode = SelectionMode.MultiExtended;
            var empNameList = context.Employees.Local.Select(x => x.Name);
            empNameListBox.Items.Clear();
            empNameListBox.Items.AddRange(empNameList.ToArray());

            brandNameListBox.Items.Clear();
            brandNameListBox.SelectionMode = SelectionMode.MultiExtended;
            var productBrandList = context.Products.Local.Select(x => x.Brand);
            brandNameListBox.Items.Clear();
            brandNameListBox.Items.AddRange(productBrandList.ToArray());
        }
        private class OrdersDetails
        {
            [DisplayName("Seller Name")]
            public string SellerName { get; set; }
            [DisplayName("Quantity")]
            public int Quantity { get; set; }

            [DisplayName("Transaction ID")]
            public int TransactionID { get; set; }

            [DisplayName("Product Name")]
            public string ProductName { get; set; }

            [DisplayName("Product Price")]
            public decimal ProductPrice { get; set; }

        }

    }
}