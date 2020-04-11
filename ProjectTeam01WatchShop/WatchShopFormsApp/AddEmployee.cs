using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WatchShopDAL;

namespace WatchShopFormsApp
{
    /// <summary>
    /// Registering an Employee
    /// </summary>
    public partial class AddEmployee : Form
    {
        private WatchShopEntities context;
        private Role selectedRoles;
        public AddEmployee(WatchShopEntities context)
        {
            InitializeComponent();
            this.context = context;
            InitializeOthers();
        }

        public void InitializeOthers()
        {
            context.Roles.Load();
            context.Employees.Load();
            


            // when click to item of student list box
            empRoleListBox.SelectedIndexChanged += (s, e) =>
            {
                selectedRoles = context.Roles.Local.ToArray()[empRoleListBox.SelectedIndex];

            };

            // Validation to check none of the fields are empty
            registerButton.Click += (s, e) =>
            {
                if (empNameTextBox.Text == "" || passwordTextBox.Text == "" || empEmailTextBox.Text == "" || phnNoTextBox.Text == "" || empAddressTextBox.Text=="")
                {
                    MessageBox.Show("Address, Password, Email, Phone number cannot be empty");
                }
                // Validate that same email Id does not exist
                else if(context.Employees.Local.ToList().Where(p => p.Email.Equals(empEmailTextBox.Text)).Count() > 0)
                {
                        MessageBox.Show("Employee Already Exixts with the same email Id. Please enter different Email ID");
                }
                else
                {

                    Employee newEmp = new Employee
                    {
                        Id = context.Employees.Local.ToArray().Length + 1,
                        Name = empNameTextBox.Text.ToString(),
                        Address = empAddressTextBox.Text.ToString(),
                        Password = passwordTextBox.Text.ToString(),
                        Email = empEmailTextBox.Text.ToString(),
                        PhoneNo = phnNoTextBox.Text.ToString(),

                    };
                    if (selectedRoles != null)
                    {
                        newEmp.RoleId = selectedRoles.Id;
                    }
                    else
                    {
                        newEmp.RoleId = null;
                    }
                    var newRow = context.Set<Employee>();
                    newRow.Add(newEmp);
                    MessageBox.Show("Employee Added Successfully");
                    context.Employees.Add(newEmp);
                    context.SaveChanges();
                    renderListBox();
                }
            };

            // render listbox
            renderListBox();
        }

        /// <summary>
        /// Get all the employee list and empty all the other textboxes
        /// </summary>
        public void renderListBox()
        {
            empNameTextBox.Text = "";
            empAddressTextBox.Text = "";
            passwordTextBox.Text = "";
            empEmailTextBox.Text = "";
            phnNoTextBox.Text = "";
            var empRolesList = context.Roles.Local.Select(x => x.Type);
            empRoleListBox.Items.Clear();
            empRoleListBox.Items.AddRange(empRolesList.ToArray());

            selectedRoles = null;
        }
    
}
}
