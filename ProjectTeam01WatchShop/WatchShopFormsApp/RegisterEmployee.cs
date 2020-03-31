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
    public partial class RegisterEmployee : Form
    {
        private WatchShopEntities context;
        public RegisterEmployee(WatchShopEntities context)
        {
            InitializeComponent();
            this.context = new WatchShopEntities();
            renderListBox();
            InitializeOthers();
        }

        public void renderListBox()
        {
            // var empRolesList = context.MasterRoles.Local.Select(x => x.RoleType);
            List<String> empRolesList = new List<String>();
            empRolesList.Add("Sales Associate");
            empRolesList.Add("Manager");
            empRolesList.Add("Admin");

            listBoxEmpRole.Items.Clear();
            listBoxEmpRole.Items.AddRange(empRolesList.ToArray());

            /*// clear selectedDepartment
            selectedDepartment = null;*/
        }

        private void InitializeOthers()
        {
            buttonRegister.Click += ButtonRegister_Click;
        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        { 


           /*Role masterRole = new Role
            {
                Id = context.Roles.Local.ToArray().Length + 1,
                Type = "Ronak"
            };
            
            context.Roles.Add(masterRole);
            context.SaveChanges();*/
          
            Employee newEmp = new Employee
            {
                Id = context.Employees.Local.ToArray().Length + 1,
                Name = textBoxEmpName.Text,
                Address = textBoxEmpAddress.Text,
                Password = textBoxPassword.Text,
                Email = "ronak@gmail.com",
                PhoneNo = "778",
                RoleId = 1

            };
            var newRow = context.Set<WatchShopDAL.Employee>();
            newRow.Add(newEmp);

           // context.Employees.Add(newEmp);
            context.SaveChanges();
            
            dataGridViewDepartments.DataSource = context.Employees.Local.ToBindingList();
            dataGridViewDepartments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDepartments.AllowUserToAddRows = false;
            // don't let users edit the Department key
            //dataGridViewDepartments.RowEnter += (s, e) => KeysReadOnly(s, e, "DepartmentId");
           // dataGridViewDepartments.Columns["Courses"].Visible = false;
            //dataGridViewDepartments.Columns["Students"].Visible = false;
            // this must be done before user deletes row to cascade. only needed when using composite keys
            // UserDeletedRow will not work, as this will try to updated Courses which will crash
          //  dataGridViewDepartments.UserDeletingRow += (s, e) => DeletingDepartment(e);
            //dataGridViewDepartments.CellValueChanged += (s, e) => AddOrUpdateDepartment(e);
            //dataGridViewDepartments.RowValidated += (s, e) => AddOrUpdateDepartment(e);

            //dataGridViewStudentRegistration.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dataGridViewStudentRegistration.ReadOnly = true;
        }
    }
}
