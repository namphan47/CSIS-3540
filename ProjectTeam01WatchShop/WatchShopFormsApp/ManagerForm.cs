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
    public partial class ManagerForm : Form
    {
        private WatchShopEntities context;
        private RegisterEmployee registerEmployee;
        public ManagerForm(WatchShopEntities context)
        {
            InitializeComponent();
            this.context = context;
            btnRegisterEmployee.Click += BtnRegisterEmployee_Click;
        }

        private void BtnRegisterEmployee_Click(object sender, EventArgs e)
        {
            registerEmployee = new RegisterEmployee(context);
            registerEmployee.Show();


        }
    }
}
