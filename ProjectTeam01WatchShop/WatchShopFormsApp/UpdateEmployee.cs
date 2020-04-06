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
    public partial class UpdateEmployee : Form
    {
        private WatchShopEntities context;
        private Role selectedRoles;
        public UpdateEmployee(WatchShopEntities context)
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
            updateEmployeesListBox.SelectedIndexChanged += (s, e) =>
            {
                Employee student = context.Employees.Local.ToArray()[updateEmployeesListBox.SelectedIndex];
                updateEmpAddressTextBox.Text = student.Address;
                updatePasswordTextBox.Text = student.Password;
                updateEmpEmailTextBox.Text = student.Email;
                updatePhnNoTextBox.Text = student.PhoneNo;
                selectedRoles = context.Roles.Local.Where(x => x.Id == student.RoleId).FirstOrDefault();
                updateEmpRoleListBox.SelectedIndex = Array.IndexOf(context.Roles.Local.ToArray(), selectedRoles);
            };


            // when click to item of student list box
             updateEmpRoleListBox.SelectedIndexChanged += (s, e) =>
             {
                 selectedRoles = context.Roles.Local.ToArray()[updateEmpRoleListBox.SelectedIndex];

             };


            updateEmployeeButton.Click += (s, e) =>
            {
                if (updateEmpAddressTextBox.Text == "" || updatePasswordTextBox.Text == "" || updateEmpEmailTextBox.Text=="" || updatePhnNoTextBox.Text == "")
                {
                    MessageBox.Show("Address, Password, Email, Phone number cannot be empty");
                }
                else
                {
                    Employee employee = context.Employees.Local.ToArray()[updateEmployeesListBox.SelectedIndex];
                    employee.Address = updateEmpAddressTextBox.Text;
                    employee.Password = updatePasswordTextBox.Text;
                    employee.Email = updateEmpEmailTextBox.Text;
                    employee.PhoneNo = updatePhnNoTextBox.Text;

                    if (selectedRoles != null)
                    {
                        employee.RoleId = selectedRoles.Id;
                    }
                    else
                    {
                        employee.RoleId = null;
                    }

                    context.SaveChanges();
                    renderListBox();

                }
            };

            // render listbox
            renderListBox();
        }

        public void renderListBox()
        {
           
            var list = context.Employees.Local
              .Select(x => x.Name.ToString());

            updateEmployeesListBox.Items.Clear();
            updateEmployeesListBox.Items.AddRange(list.ToArray());

            updateEmpAddressTextBox.Text = "";
            updatePasswordTextBox.Text = "";
            updateEmpEmailTextBox.Text = "";
            updatePhnNoTextBox.Text = "";
            
           


           var empRolesList = context.Roles.Local.Select(x => x.Type);
            updateEmpRoleListBox.Items.Clear();
            updateEmpRoleListBox.Items.AddRange(empRolesList.ToArray());

            selectedRoles = null;
        }
    }
}
