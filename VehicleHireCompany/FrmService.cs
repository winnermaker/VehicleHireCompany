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
    }
}
