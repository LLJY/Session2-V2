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
    public partial class ManageRequest : Form
    {
        ManageRequestInfo CurrentInfo;
        Employee LoggedInUser;
        int EmergencyInfoID;
        public ManageRequest(Employee employee, int emID)
        {
            LoggedInUser = employee;
            EmergencyInfoID = emID;
            Initialize();
        }
        private async void Initialize()
        {
            var dbTask = DBController.getEMInfo(EmergencyInfoID);
            InitializeComponent();
            //fill up the ui after waiting
            CurrentInfo = await dbTask;
            asset_sn_label.Text = CurrentInfo.AssetSN;
            asset_name_label.Text = CurrentInfo.AssetName;
            department_label.Text = CurrentInfo.Department;
            if (CurrentInfo.StartDate != null)
            {
                StartDatePicker.Value = (DateTime)CurrentInfo.StartDate;
            }
            if(CurrentInfo.EndDate != null)
            {
                EndDatePicker.Value = (DateTime)CurrentInfo.EndDate;
            }
            tech_note_richbox.Text = CurrentInfo.TechnicianNote;
            parts_combo.DataSource = CurrentInfo.listOfParts;
            CurrentInfo.AddedParts = new List<PartsDGV>();
        }

        private async void Send_button_Click(object sender, EventArgs e)
        {
            CurrentInfo.AssetSN = asset_sn_label.Text;
            CurrentInfo.AssetName = asset_name_label.Text;
            CurrentInfo.Department = department_label.Text;
            CurrentInfo.StartDate = StartDatePicker.Value;
            CurrentInfo.EndDate = EndDatePicker.Value;
            CurrentInfo.TechnicianNote = tech_note_richbox.Text;
            await DBController.updateEMData(CurrentInfo);
            Back_button_Click(sender, e);
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var MA = new ManageAssets(LoggedInUser);
            MA.Closed += (s, args) => this.Close();
            MA.Show();
        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            if(parts_combo.SelectedItem != null && amount_updown.Value != 0)
            {
                //add part to dgv and refresh
                PartsDGV part = new PartsDGV();
                part.PartName = parts_combo.SelectedItem.ToString();
                part.Amount = (int)amount_updown.Value;
                CurrentInfo.AddedParts.Add(part);
                refreshDGV();
            }
        }

        private void Remove_button_Click(object sender, EventArgs e)
        {
            try
            {
                //will error out if empty, just try catch because laziness
                CurrentInfo.AddedParts.Remove(CurrentInfo.AddedParts[parts_dgv.CurrentCell.RowIndex]);
            }catch (Exception)
            {

            }
            refreshDGV();
        }
        private void refreshDGV()
        {
            parts_dgv.DataSource = null;
            parts_dgv.DataSource = CurrentInfo.AddedParts;
            parts_dgv.Columns[0].HeaderText = "Part Name";
        }
    }
    public class ManageRequestInfo
    {
        public int EMID { get; set; }
        public int AssetID { get; set; }
        public string AssetSN { get; set; }
        public string Department { get; set; }
        public string TechnicianNote { get; set; }
        public string AssetName { get; set; }
        public int Amount { get; set; }
        public List<PartsDGV> AddedParts { get; set; }
        public List<string> listOfParts { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
    public class PartsDGV
    {
        public string PartName { get; set; }
        public int Amount { get; set; }
    }
}
