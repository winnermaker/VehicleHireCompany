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
    public partial class FrmVehicle : Form
    {
        private FrmActivityLog _ActivityLogForm = new FrmActivityLog();
        protected ClsVehicle _Vehicle = new ClsVehicle();

        public FrmVehicle()
        {
            InitializeComponent();
            UpdateDisplay();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtRegNumber.Enabled && ClsCompany.VehicleList.ContainsKey(txtRegNumber.Text))
                MessageBox.Show("Car with that RegistrationNumber already exists", "Duplicate RegistrationNumber");
            else
            {
                PushData();
                if (txtRegNumber.Text != "" && txtModel.Text != "" && txtmake.Text != "")
                {
                    ClsVehicle lcVehicle = _Vehicle;
                    if (lcVehicle != null && txtRegNumber.Enabled)
                    {
                        ClsCompany.VehicleList.Add(lcVehicle.RegistrationNumber, lcVehicle);
                    }
                }
                else
                {
                    MessageBox.Show("A Least one Field is empty. Please insert missing Data", "Field Empty");
                }
                
                DialogResult = DialogResult.OK;                
            }
        }

        private void UpdateDisplay()
        {
            txtRegNumber.Text = _Vehicle.RegistrationNumber;
            txtModel.Text = _Vehicle.Model;
            txtmake.Text = _Vehicle.Make;
            nudHireCharge.Value = _Vehicle.DailyHireCharge;
            txtRegNumber.Enabled = String.IsNullOrEmpty(_Vehicle.RegistrationNumber);
            dtpYear.Value = Convert.ToDateTime( ("01/01/"+_Vehicle.Year));
        }

        private void PushData()
        {
            _Vehicle.RegistrationNumber = txtRegNumber.Text;
            _Vehicle.Model = txtModel.Text;
            _Vehicle.Make = txtmake.Text;
            _Vehicle.Year = dtpYear.Value.Year;
            _Vehicle.DailyHireCharge = nudHireCharge.Value;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnActivity_Click(object sender, EventArgs e)
        {
            PushData();
            _ActivityLogForm.ShowDialog(_Vehicle);
        }
        
        public DialogResult ShowDialog(ClsVehicle prVehicle)
        {
            _Vehicle = prVehicle;
            UpdateDisplay();
            return ShowDialog();
        }
    }
}