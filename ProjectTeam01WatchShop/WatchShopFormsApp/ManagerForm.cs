using System;
using System.Windows.Forms;
using WatchShopDAL;

namespace WatchShopFormsApp
{
    public partial class ManagerForm : Form
    {
        private WatchShopEntities context;
        private ManagerStoreReport managerStoreReport;
        private RegisterEmployee registerEmployee;
        public ManagerForm(WatchShopEntities context)
        {
            InitializeComponent();
            this.context = context;
            registerEmployeeBtn.Click += BtnRegisterEmployee_Click;
            reportGenerationBtn.Click += BtnReportGeneration_Click;
        }

        private void BtnReportGeneration_Click(object sender, EventArgs e)
        {
            managerStoreReport = new ManagerStoreReport(context);
            managerStoreReport.Show();
        }

        private void BtnRegisterEmployee_Click(object sender, EventArgs e)
        {
            registerEmployee = new RegisterEmployee(context);
            registerEmployee.Show();


        }
    }
}
