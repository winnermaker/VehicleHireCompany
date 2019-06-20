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
    public partial class FrmActivity : Form
    {
        protected ClsActivity _Activity;
        public FrmActivity()
        {
            InitializeComponent();
        }
        
        protected virtual void btnOK_Click(object sender, EventArgs e)
        {
            PushData();
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
            DialogResult = DialogResult.Cancel;
        }


        public Boolean ShowDialog(ClsActivity prActivity)
        {            
            _Activity = prActivity;
            UpdateDisplay();
            DialogResult result = ShowDialog();
            return result == DialogResult.OK;
        }

        protected virtual void UpdateDisplay()
        {
            txtName.Text = _Activity.Name;
            nudValue.Value = _Activity.Value;
            dtpActivityDate.Value = _Activity.Date;
        
        }
        protected virtual void PushData()
        {
            _Activity.Name = txtName.Text;
            _Activity.Value = nudValue.Value;
            _Activity.Date = dtpActivityDate.Value;

        }
    }
}
