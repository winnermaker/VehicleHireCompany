using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleHireCompany
{
    public partial class FrmActivityLog : Form
    {
        private ClsVehicle _Vehicle;
        public FrmActivityLog()
        {
            InitializeComponent();
            cbActivityChoice.DataSource = ClsActivity.ActivityType;
            cbActivityChoice.SelectedIndex = 0;
        }
        private void UpdateDisplay()
        {
            lstActivities.DataSource = null;
            lstActivities.DataSource = _Vehicle.ActivityList;
            DisplayHireCost();
            lblValue.Text = string.Format("{0:C} ", _Vehicle.TotalValue());
            lblRegNumber.Text = _Vehicle.RegistrationNumber;
            _Vehicle.SortList(rbtnName.Checked);   
        }

        private void DisplayHireCost()
        {
            if (_Vehicle.ActivityList != null)
            {
                int count = 0;
                foreach (ClsActivity lcActivity in _Vehicle.ActivityList)
                {
                    if (lcActivity.TypeOfActivity() == "Hire")
                    {
                        ClsHire hire = (ClsHire)_Vehicle.ActivityList[count];
                        hire.Value = hire.CalculateCost(hire.Date.Date, hire.EndDate.Date, _Vehicle.DailyHireCharge);
                    }
                    count++;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClsActivity lcActivity = ClsActivity.NewActivity(cbActivityChoice.SelectedIndex);
            if (lcActivity != null && lcActivity.ViewEdit())
            {
                _Vehicle.ActivityList.Add(lcActivity);
                UpdateDisplay();
            }            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditActivity();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ClsActivity lcActivity = (ClsActivity)lstActivities.SelectedItem;
            if (lcActivity != null && DialogResult.Yes == MessageBox.Show("Are you sure you want to delete the selected Activity?", "Delete Activity", MessageBoxButtons.YesNo))
            {
                _Vehicle.ActivityList.Remove(lcActivity);
                UpdateDisplay();
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditActivity()
        {
            ClsActivity lcActivity = (ClsActivity)lstActivities.SelectedItem;            
            if (lcActivity != null && lcActivity.ViewEdit())
            {
                UpdateDisplay();
            }
        }

        private void lstActivities_DoubleClick(object sender, EventArgs e)
        {
            EditActivity();
        }

        public DialogResult ShowDialog(ClsVehicle prVehicle)
        {
            _Vehicle = prVehicle;
            UpdateDisplay();
            return ShowDialog();
        }
        
        private void rbtnName_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        private void FrmActivityLog_Load(object sender, EventArgs e)
        {
            UpdateDisplay();
        }
    }
}
