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
        private UpdateEmployee updateEmployee;
        private Role selectedRoles;
        private AddEmployee addEmployee;
        public RegisterEmployee(WatchShopEntities context)
        {
            InitializeComponent();
            this.context = context;
            this.Load += RegisterEmployee_Load;
            InititializeDataGridView();
            InititializeOthers();

        }

        private void InititializeOthers()
        {
            addButton.Click += AddButton_Click;
            updateButton.Click += ButtonUpdate_Click;
            dropButton.Click += DropButton_Click;
        }

        private void DropButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewDepartments.SelectedRows)
            {
                Employee employeeRecord = row.DataBoundItem as Employee;
                context.Employees.Remove(employeeRecord);
                context.SaveChanges();
            }
            //SaveChangesAndUpdateRegistration();
        }

        private void RegisterEmployee_Load(object sender, EventArgs e)
        {
            SeedRegistrationDataTables();
        }

        private void SeedRegistrationDataTables()
        {

            // reset the db
            //context.Database.Delete();
            //context.Database.Create();

            //context.SaveChanges();

            // another way to reinitialize the database, resetting everything and zeroing out data

            //Database.SetInitializer(new DropCreateDatabaseAlways<StudentRegistrationEntities>());
            //context.Database.Initialize(true);        
            context.Roles.Load();
            context.Employees.Load();


        }

       

        private void AddButton_Click(object sender, EventArgs e)
        {
            addEmployee = new AddEmployee(context);
            addEmployee.Show();
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            updateEmployee = new UpdateEmployee(context);
            updateEmployee.Show();
        }

        private void InititializeDataGridView()
        {
            dataGridViewDepartments.DataSource = context.Employees.Local.ToBindingList();
            dataGridViewDepartments.Columns["Orders"].Visible = false;
            dataGridViewDepartments.Columns["Transactions"].Visible = false;
            //dataGridViewDepartments.Columns["RoleID"].Visible = false;
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
