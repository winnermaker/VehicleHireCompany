using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VehicleHireCompany
{
    public partial class FrmService : VehicleHireCompany.FrmActivity
    {
        public FrmService()
        {
            InitializeComponent();
        }
        protected override void UpdateDisplay()
        {
            base.UpdateDisplay();
            ClsService lcActivity = (ClsService)_Activity;
            txtWorkshop.Text = lcActivity.Workshop;

        }

        protected override void PushData()
        {
            base.PushData();
            ClsService lcActivity = (ClsService)_Activity;
            lcActivity.Workshop = txtWorkshop.Text;
        }

        protected override void btnOK_Click(object sender, EventArgs e)
        {
            ClsService lcActivity = (ClsService)_Activity;
            PushData();
            if (txtName.Text != "" && txtWorkshop.Text != "")
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
