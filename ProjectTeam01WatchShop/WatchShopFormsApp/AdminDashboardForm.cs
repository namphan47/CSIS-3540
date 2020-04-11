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
    public partial class AdminDashboardForm : Form
    {
        private WatchShopEntities context;
        private UpdateInventory updateInventory;

        public AdminDashboardForm(WatchShopEntities context)
        {
            InitializeComponent();
            this.context = context;
            updateInventoryButton.Click += UpdateInventoryButton_Click;
            backUpDbButton.Click += BackUpDbButton_Click;
            restroreDbButton.Click += RestroreDbButton_Click;
        }

        private void RestroreDbButton_Click(object sender, EventArgs e)
        {
            
        }

        private void BackUpDbButton_Click(object sender, EventArgs e)
        {
            
        }

        private void UpdateInventoryButton_Click(object sender, EventArgs e)
        {
            updateInventory = new UpdateInventory(context);
            updateInventory.Show();
        }
    }
}
