using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VehicleHireCompany
{
    public partial class FrmHire : VehicleHireCompany.FrmActivity
    {
        public FrmHire()
        {
            InitializeComponent();
        }
        protected override void UpdateDisplay()
        {
            base.UpdateDisplay();
            ClsHire lcActivity = (ClsHire)_Activity;
            txtCustomer.Text = lcActivity.CustName;
            dtpEndDate.Value = lcActivity.EndDate;
        }

        protected override void PushData()
        {
            base.PushData();
            ClsHire lcActivity = (ClsHire)_Activity;
            lcActivity.EndDate = dtpEndDate.Value;
            lcActivity.CustName = txtCustomer.Text;            
        }

        protected override void btnOK_Click(object sender, EventArgs e)
        {
            PushData();
            ClsHire lcActivity = (ClsHire)_Activity;
            if (txtCustomer.Text != "" && txtName.Text != "")
            {
                if (lcActivity.EndDate.CompareTo(lcActivity.Date) >= 0) //<0:instance earlier than value. 0:instance same as value. 0<:instance later than value.
                {
                    base.btnOK_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Startdate must be before Enddate", "Invalide Dates");
                }
            }
            else
            {
                MessageBox.Show("A Least one Field is empty. Please insert missing Data", "Field Empty");
            }
        }
    }
}
