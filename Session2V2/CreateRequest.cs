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
    public partial class CreateRequest : Form
    {
        int AssetID;
        AssetEMPageInfo CurrentInfo;
        Employee LoggedInUser;
        public CreateRequest(Employee employee, int assetID)
        {
            LoggedInUser = employee;
            AssetID = assetID;
            Initialize();
        }
        public async void Initialize()
        {
            var dbtask = DBController.GetAssetInfo(AssetID);
            InitializeComponent();
            CurrentInfo = await dbtask;
            asset_sn_label.Text = CurrentInfo.AssetSN;
            asset_name_label.Text = CurrentInfo.AssetName;
            department_label.Text = CurrentInfo.Department;
            priority_combo.DataSource = CurrentInfo.Priorities;
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var MA = new ManageAssets(LoggedInUser);
            MA.Closed += (s, args) => this.Close();
            MA.Show();
        }

        private async void Send_button_Click(object sender, EventArgs e)
        {
            CurrentInfo.Considerations = otherconsideration_richbox.Text;
            CurrentInfo.SelectedPriorities = priority_combo.SelectedItem.ToString();
            CurrentInfo.Description = desc_richbox.Text;
            await DBController.addEmergencyMaintenance(CurrentInfo);
            Back_button_Click(sender, e);
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
    public class AssetEMPageInfo
    {
        public int AssetID { get; set; }
        public string AssetSN { get; set; }
        public string AssetName { get; set; }
        public List<string> Priorities { get; set; }
        public string SelectedPriorities { get; set; }
        public string Description { get; set; }
        public string Department { get; set; }
        public string Considerations { get; set; }
    }
}
