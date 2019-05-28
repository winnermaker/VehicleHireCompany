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
    public partial class FrmMain : Form
    {
        private FrmVehicle _VehicleForm = new FrmVehicle();
        public FrmMain()
        {
            InitializeComponent();
            try
            {
                ClsCompany.Retrieve();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
            UpdateDisplay();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _VehicleForm = new FrmVehicle();
            DialogResult res = _VehicleForm.ShowDialog();
            if(res == DialogResult.OK)
            {
                UpdateDisplay();
            }
        }               

        private void UpdateDisplay()
        {
            lstVehicle.DataSource = ClsCompany.VehicleList.Keys.ToList();     
            lblValue.Text = string.Format("{0:C} ", ClsCompany.TotalValue());
        }    
        
        public void QuickView()
        {
            if (ClsCompany.VehicleList.Count != 0)
            {
                String lcRegNumber = lstVehicle.SelectedItem.ToString();
                ClsVehicle lcVehicle = ClsCompany.VehicleList[lcRegNumber];
                lblQuickView.Text = String.Format("Make:   {0}\nModel:   {1}\nYear:   {2}\nDaily Hire Charge: {3:c}", lcVehicle.Make, lcVehicle.Model,lcVehicle.Year, lcVehicle.DailyHireCharge);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {            
            Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditVehicle();

        }

        private void EditVehicle()
        {
            if (ClsCompany.VehicleList.Count != 0)
            {
                String lcRegNumber = lstVehicle.SelectedItem.ToString();
                ClsVehicle lcVehicle = ClsCompany.VehicleList[lcRegNumber];
                if (lcVehicle != null)
                {
                    _VehicleForm.ShowDialog(lcVehicle);
                    UpdateDisplay();
                }
            }
            else
            {
                MessageBox.Show("Please make sure there is a car in the list to edit.", "No car in list");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String lcRegNumber = lstVehicle.SelectedItem.ToString();
            ClsVehicle lcVehicle = ClsCompany.VehicleList[lcRegNumber];
            if (lcVehicle != null && DialogResult.Yes == MessageBox.Show("Are you sure you want to delete the selected Vehicle?", "Delete Vehicle", MessageBoxButtons.YesNo))
            {
                ClsCompany.VehicleList.Remove(lcVehicle.RegistrationNumber);
                UpdateDisplay();
                if (ClsCompany.VehicleList.Count == 0)
                {
                    lblQuickView.Text = "";
                }

            }
            
        }

        private void lstVehicle_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                QuickView();                
            }
            catch (Exception)
            {

            }
            
        }

        private void lstVehicle_DoubleClick(object sender, EventArgs e)
        {
            EditVehicle();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                ClsCompany.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something went wrong while saving");
            }
        }
    }
}
