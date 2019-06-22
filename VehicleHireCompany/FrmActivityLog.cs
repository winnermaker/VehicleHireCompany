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
        private ClsVehicle _Vehicle = new ClsVehicle();
        private IComparer<ClsActivity>[] _Comparer ={ new clsNameComparer(), new clsDateComparer() };
        private int _SortOrder; //sortOrder = 0 => by name; sortOrder = 1 => by date 
        public FrmActivityLog()
        {
            InitializeComponent();
            cbActivityChoice.DataSource = ClsActivity.ActivityType;
            cbActivityChoice.SelectedIndex = 0;
            rbtnName.Checked = true;
            _SortOrder = 0;
        }
        private void UpdateDisplay()
        {
            List<ClsActivity> lcActivityList = _Vehicle.ActivityList;
            lblValue.Text = string.Format("{0:C} ", _Vehicle.TotalValue());
            lcActivityList.Sort(_Comparer[_SortOrder]);
            lstActivities.DataSource = null; //force refresh
            lstActivities.DataSource = lcActivityList;  
            lblRegNumber.Text = _Vehicle.RegistrationNumber;
        }

        private void DisplayHireCost()
        {
            if (_Vehicle.ActivityList != null)
            {
                int count = 0;
                foreach (ClsActivity lcActivity in _Vehicle.ActivityList)
                {
                    switch (lcActivity.TypeOfActivity())
                    {
                        case "Hire":
                            ClsHire hire = (ClsHire)_Vehicle.ActivityList[count];
                            hire.Value = hire.CalculateValue(_Vehicle.DailyHireCharge);
                            
                            break;
                        case "Relocate":
                            ClsRelocate relocate = (ClsRelocate )_Vehicle.ActivityList[count];
                            relocate.Value = relocate.CalculateValue(lcActivity.Value);
                            break;
                        default:
                            ClsService service = (ClsService)_Vehicle.ActivityList[count];
                            service.Value = service.CalculateValue(lcActivity.Value);
                            break;
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
                DisplayHireCost();
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


        private void rbtnDate_CheckedChanged(object sender, EventArgs e)
        {
            //sortOrder = 1 => by name; sortOrder = 0 => by date 
            if (rbtnDate.Checked)
            {
                _SortOrder = 1;
            }
            else
            {
                _SortOrder = 0;;
            }
            UpdateDisplay();
        }

        private void FrmActivityLog_Load(object sender, EventArgs e)
        {
            DisplayHireCost();
            UpdateDisplay();
        }

        class clsDateComparer : IComparer<ClsActivity>
        {
            public int Compare(ClsActivity prActivityX, ClsActivity prActivityY)
            { 
                int lcResult = prActivityX.Date.Date.CompareTo(prActivityY.Date.Date);
                if(lcResult != 0)
                {
                    return lcResult;
                }
                else
                {
                    return prActivityX.Name.CompareTo(prActivityY.Name);
                }
            }
        }

        class clsNameComparer : IComparer<ClsActivity>
        {
            public int Compare(ClsActivity prActivityX, ClsActivity prActivityY)
            {/*Assign lcResult  prStudentX.Name.CompareTo(prStudentY.Name)
                If lcResult<> 0
                Return lcResult
                Else
                Return prStudentX.DOB.Date.CompareTo(prStudentY.DOB.Date)*/
                int lcResult = prActivityX.Name.CompareTo(prActivityY.Name);
                if (lcResult != 0)
                {
                    return lcResult;
                }
                else
                {
                    return prActivityX.Date.Date.CompareTo(prActivityY.Date.Date);
                }
            }
        }
    }
}
