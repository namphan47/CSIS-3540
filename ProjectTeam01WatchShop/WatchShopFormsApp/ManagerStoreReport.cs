using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using WatchShopDAL;

namespace WatchShopFormsApp
{
    public partial class ManagerStoreReport : Form
    {
        private WatchShopEntities context;
        public ManagerStoreReport(WatchShopEntities context)
        {
            InitializeComponent();
            this.context = context;
            InititializeDataGridView();
        }

        /// <summary>
        /// Getting all the transactions 
        /// </summary>
        private void InititializeDataGridView()
        {
            var totalTax = 0M;
            var amtBeforeTax = 0M;
            var amtAfterTax = 0M;
            managerStoreDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            managerStoreDataGridView.AllowUserToAddRows = false;
            managerStoreDataGridView.ReadOnly = true;
            managerStoreDataGridView.RowHeadersVisible = false;
            managerStoreDataGridView.AllowUserToDeleteRows = false;
            managerStoreDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            managerStoreDataGridView.RowHeadersVisible = false;
            managerStoreDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            managerStoreDataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            managerStoreDataGridView.Columns.Clear();
            context.Transactions.Load();
            List<Transaction> transactionsList = new List<Transaction>();
            transactionsList = context.Transactions.Local.ToList();
            managerStoreDataGridView.DataSource = transactionsList;
            totalTax = transactionsList.Select(t => t.TaxAmount).Sum();
            amtBeforeTax = transactionsList.Select(t => t.SubTotal).Sum();
            amtAfterTax = transactionsList.Select(t => t.TotalAmount).Sum();
            totalTaxTextBox.Text = totalTax.ToString("C2");
            totalAmtBeforeTextBox.Text = amtBeforeTax.ToString("C2");
            totalAmtAfterTextBox.Text = amtAfterTax.ToString("C2");
            managerStoreDataGridView.Columns["Orders"].Visible = false;
            managerStoreDataGridView.Columns["Employee"].Visible = false;

        }

    }
}

