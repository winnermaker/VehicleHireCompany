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
            nudKM.Value = lcActivity.NumberOfKM;
        }

        protected override void PushData()
        {
            base.PushData();
            ClsRelocate lcActivity = (ClsRelocate)_Activity;
            lcActivity.NumberOfKM =Convert.ToInt16(nudKM.Value);

        }

        protected override void btnOK_Click(object sender, EventArgs e)
        {
            ClsRelocate lcActivity = (ClsRelocate)_Activity;
            PushData();
            if (txtName.Text != "")
            {
                base.btnOK_Click(sender, e);
            }
            else
            {
                MessageBox.Show("A Least one Field is empty. Please insert missing Data", "Field Empty");
            }
        }
    }
}
