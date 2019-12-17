using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session2V2
{
    public partial class LoginForm : Form
    {
        List<Employee> Employees;
        public LoginForm()
        {
            Initialize();
        }
        public async void Initialize()
        {
            var dbTask = DBController.GetEmployees();
            InitializeComponent();
            Employees = await dbTask;
        }
        public async Task<Employee> checkLogin(string username, string password)
        {
            //this function returns employee if login is valid
            //returns null otherwise
            return (from e in Employees
                    where e.Username == username
                    where e.Password == password
                    select e).First();
        }
        private async void Login_button_Click(object sender, EventArgs e)
        {
            Employee login = await checkLogin(username_box.Text, password_box.Text);
            if(login != null)
            {
                this.Hide();
                var MA = new ManageAssets(login);
                MA.Closed += (s, args) => this.Close();
                MA.Show();
            }
            else
            {
                MessageBox.Show("invalid login", "eh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Kill_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Josfa_Click(object sender, EventArgs e)
        {
            username_box.Text = "josefa";
            password_box.Text = "1324";
            Login_button_Click(sender, e);
        }

        private void Lyn_Click(object sender, EventArgs e)
        {
            username_box.Text = "lyn";
            password_box.Text = "1234";
            Login_button_Click(sender, e);
        }
    }
}
