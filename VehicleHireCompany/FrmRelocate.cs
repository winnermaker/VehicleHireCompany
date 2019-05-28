using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VehicleHireCompany
{
    public partial class FrmRelocate : VehicleHireCompany.FrmActivity
    {
        public FrmRelocate()
        {
            InitializeComponent();
        }
        protected override void UpdateDisplay()
        {
            base.UpdateDisplay();
            ClsRelocate lcActivity = (ClsRelocate)_Activity;
            txtKm.Text = lcActivity.NumberOfKM.ToString();
        }

        protected override void PushData()
        {
            base.PushData();
            ClsRelocate lcActivity = (ClsRelocate)_Activity;
            lcActivity.NumberOfKM = Convert.ToUInt16(txtKm.Text);

        }
    }
}
