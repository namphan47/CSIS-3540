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
        public SalesAssociateForm(WatchShopEntities context)
        {
            InitializeComponent();
            this.context = context;
        }
    }
}
