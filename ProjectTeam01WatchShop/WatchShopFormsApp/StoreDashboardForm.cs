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
    public partial class StoreDashboardForm : Form
    {
        private WatchShopEntities context;
        private CartForm cartForm;
        public StoreDashboardForm(WatchShopEntities context)
        {
            InitializeComponent();
            this.context = context;

            buttonViewCart.Click += (s, e) =>
            {
                cartForm = new CartForm();
                cartForm.Show();
            };
        }
    }
}
