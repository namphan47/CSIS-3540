using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WatchShopCodeFirstDB;

namespace WatchShopFormsApp
{
    public partial class WatchShopMainFormApp : Form
    {
        private WatchShopEntities context;
        private SalesAssociateForm salesAssociateForm;
        public WatchShopMainFormApp()
        {
            InitializeComponent();
            context = new WatchShopEntities(); 
            buttonSalesAssociate.Click += ButtonSalesAssociate_Click;
        }

        private void ButtonSalesAssociate_Click(object sender, EventArgs e)
        {
            salesAssociateForm = new SalesAssociateForm(context);
            salesAssociateForm.Show();
        }
    }
}
