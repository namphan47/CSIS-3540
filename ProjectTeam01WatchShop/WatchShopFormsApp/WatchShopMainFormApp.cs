using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WatchShopDAL;

namespace WatchShopFormsApp
{
    public partial class WatchShopMainFormApp : Form
    {
        private WatchShopEntities context;
        private SalesAssociateForm salesAssociateForm;
        private AdminDashboardForm adminDashboardForm;
        private StoreDashboardForm storeDashboardForm;
        private ManagerForm managerForm;

        public WatchShopMainFormApp()
        {
            InitializeComponent();
            context = new WatchShopEntities();

            // seed data
            SeedRegistrationDataTables();

            buttonSalesAssociate.Click += ButtonSalesAssociate_Click;
            buttonAdmin.Click += (s, e) =>
            {
                adminDashboardForm = new AdminDashboardForm(context);
                adminDashboardForm.Show();
            };
            buttonStore.Click += (s, e) =>
            {
                storeDashboardForm = new StoreDashboardForm(context);
                storeDashboardForm.Show();
            };
            buttonManager.Click += ButtonManager_Click;
        }

        private void SeedRegistrationDataTables()
        {
            // set up database log to write to output window in VS
            context.Database.Log = (s => Debug.Write(s));
                    
            context.Products.Load();
            context.Employees.Load();
        }

        private void ButtonManager_Click(object sender, EventArgs e)
        {
            managerForm = new ManagerForm(context);
            managerForm.Show();
        }
        private void ButtonSalesAssociate_Click(object sender, EventArgs e)
        {
            salesAssociateForm = new SalesAssociateForm(context);
            salesAssociateForm.Show();
        }

    }
}
