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
    public partial class UpdateEmpPersonalDetails : Form
    {
        private WatchShopEntities context;
        public UpdateEmpPersonalDetails(WatchShopEntities context)
        {
            InitializeComponent();
            this.context = context;
            InitializeOthers();
        }

        private void InitializeOthers()
        {
            Employee employee = null; ;


            checkEmpButton.Click += (s, e) =>
            {
                string empEmail = upEmpEmailTextBox.Text.ToString();
                string empPassword = upPasswordTextBox.Text.ToString();
                employee = context.Employees.Local.Select(x => x).Where(x => x.Email.Equals(empEmail)).Where(x => x.Password.Equals(empPassword)).FirstOrDefault();
                if (null != employee)
                {
                    upEmpAddressTextBox.ReadOnly = false;
                    upPasswordTextBox.ReadOnly = false;
                    upEmpEmailTextBox.ReadOnly = false;
                    upPhnNoTextBox.ReadOnly = false;
                    updateEmpButton.Enabled = true;
                    upEmpAddressTextBox.Text = employee.Address;
                    upPasswordTextBox.Text = employee.Password;
                    upEmpEmailTextBox.Text = employee.Email;
                    upPhnNoTextBox.Text = employee.PhoneNo;
                }
                else
                {
                    MessageBox.Show("No such Employee Exists");
                    
                }

            };

            updateEmpButton.Click += (s, e) =>
            {
                if (upEmpAddressTextBox.Text == "" || upPasswordTextBox.Text == "" || upEmpEmailTextBox.Text == "" || upPhnNoTextBox.Text == "")
                {
                    MessageBox.Show("Address, Password, Email, Phone number cannot be empty");
                }
                else
                {
                    employee.Address = upEmpAddressTextBox.Text;
                    employee.Password = upPasswordTextBox.Text;
                    employee.Email = upEmpEmailTextBox.Text;
                    employee.PhoneNo = upPhnNoTextBox.Text;
                   int updated =  context.SaveChanges();
                    if (updated != -1)
                    {
                        MessageBox.Show("Record Updated Successfully");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("There is some pronlem with the updation. Please try again");
                    }
                    
                }
            };

            resetFields();
        }

        private void resetFields()
        {
            upEmpAddressTextBox.ReadOnly = true;
            upPhnNoTextBox.ReadOnly = true;
            updateEmpButton.Enabled = false;
        }
    }


}
