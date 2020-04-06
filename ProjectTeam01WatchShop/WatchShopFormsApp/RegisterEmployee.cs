using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
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
            employeesDataGridView.DataSource = context.Employees.Local.ToBindingList();
            employeesDataGridView.Columns["Orders"].Visible = false;
            employeesDataGridView.Columns["Transactions"].Visible = false;
            employeesDataGridView.Columns["Role"].Visible = false;
            empRolesDataGridView.DataSource = context.Roles.Local.ToBindingList();
            empRolesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            empRolesDataGridView.RowEnter += (s, e) => KeysReadOnly(s, e, "Id");
            empRolesDataGridView.CellValueChanged += (s, e) => AddOrUpdateDepartment(e);
            empRolesDataGridView.RowValidated += (s, e) => AddOrUpdateDepartment(e);
            empRolesDataGridView.Columns["Employees"].Visible = false;
            employeesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            employeesDataGridView.AllowUserToAddRows = false;
            
        }

        public void KeysReadOnly(object s, DataGridViewCellEventArgs e, params string[] keyNames)
        {
            DataGridView dgv = s as DataGridView;
            DataGridViewRow row = dgv.Rows[e.RowIndex];

            // if a new row, allow edits, otherwise make the key cells readonly

            if (row.IsNewRow)
                row.ReadOnly = false;
            else
            {
                foreach (string keyName in keyNames)
                {
                    row.Cells[keyName].ReadOnly = true;
                }
            }
        }

        private void AddOrUpdateDepartment(DataGridViewCellEventArgs e)
        {
           
            Role role = context.Roles.Local.ElementAtOrDefault(e.RowIndex);

            
            if (context.ChangeTracker.HasChanges() == false || role == null)
                return;

            

            DbEntityEntry entry = context.Entry<Role>(role);

            if (entry.State == EntityState.Added)
            {
                if (context.Roles.FirstOrDefault(d => d.Id == role.Id) != null
                    || role.Type == null || role.Type == null)
                {
                    MessageBox.Show("Roles cannot be added, already exists"
                                                + role);
                    context.Roles.Remove(role);
                }
                context.SaveChanges();
                empRolesDataGridView.Refresh();
            }
            else if (entry.State == EntityState.Modified)
            {
                if (role.Type == null)
                {
                    MessageBox.Show("Roles cannot be updated, Role name is missing: "
                                                + role);
                    entry.State = EntityState.Unchanged;
                }
                SaveChangesAndUpdateRegistration();
            }
        }

        private void SaveChangesAndUpdateRegistration()
        {

            // if there are changes, log the fact, otherwise there are none and exit

            try
            {
                context.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Error: Cannot update the database - exiting");
                Environment.Exit(1);
            }

        }

    }
}
