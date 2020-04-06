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

namespace WatchShopFormsApp
{
    
    public partial class SalesAssociateForm : Form
    {
        private WatchShopEntities context;
        private UpdateEmpPersonalDetails updateEmpPerDetails;
        private SalesReport salesReport;
        public SalesAssociateForm(WatchShopEntities context)
        {
            InitializeComponent();
            this.context = context;
            updateEmpPerDetailsButton.Click += UpdateEmpPerDetailsButton_Click;
            salesPersonButton.Click += SalesPersonButton_Click;
        }

        private void SalesPersonButton_Click(object sender, EventArgs e)
        {
            salesReport = new SalesReport(context);
            salesReport.Show();
        }

        private void UpdateEmpPerDetailsButton_Click(object sender, EventArgs e)
        {
            updateEmpPerDetails = new UpdateEmpPersonalDetails(context);
            updateEmpPerDetails.Show();
        }

       
    }
}
