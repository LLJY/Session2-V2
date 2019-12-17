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
    public partial class ManageAssets : Form
    {
        Employee LoggedInUser;
        List<AssetInfo> dgvInfo;
        List<EMRequests> dgvInfo1;
        public ManageAssets(Employee employee)
        {
            LoggedInUser = employee;
            Initialize();
        }
        public async void Initialize()
        {
            if (LoggedInUser.isAdmin != true)
            {
                var dbTask = DBController.getAssets((int)LoggedInUser.ID);
                InitializeComponent();
                multi_func_button.Text = "Send Emergency Maintenance Request";
                dgvInfo = await dbTask;
                dataGridView1.DataSource = dgvInfo;
            }
            else
            {
                var dbtask = DBController.getOpenRequests();
                InitializeComponent();
                multi_func_button.Text = "Manage Request";
                dgvInfo1 = await dbtask;
                dataGridView1.DataSource = dgvInfo1;
            }
        }

        private void Multi_func_button_Click(object sender, EventArgs e)
        {
            if (LoggedInUser.isAdmin != true)
            {
                this.Hide();
                var MA = new CreateRequest(LoggedInUser, dgvInfo[dataGridView1.CurrentCell.RowIndex].AssetID);
                MA.Closed += (s, args) => this.Close();
                MA.Show();
            }
            else
            {
                this.Hide();
                var MR = new ManageRequest(LoggedInUser, dgvInfo1[dataGridView1.CurrentCell.RowIndex].EMID);
                MR.Closed += (s, args) => this.Close();
                MR.Show();
            }
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            var LF = new LoginForm();
            LF.Closed += (s, args) => this.Close();
            LF.Show();
        }
    }
    public class AssetInfo
    {
        public int AssetID { get; set; }
        public string AssetSN { get; set; }
        public string AssetName { get; set; }
        public DateTime? LastClosedEM { get; set; }
        public int NumberOfEM { get; set; }

    }
    public class EMRequests
    {
        public int EMID { get; set; }
        public string AssetSN { get; set; }
        public string AssetName { get; set; }
        public DateTime RequestDate { get; set; }
        public string EmployeeName { get; set; }
        public string Department { get; set; }
    }
}
