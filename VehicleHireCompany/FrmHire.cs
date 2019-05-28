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
    }
}
