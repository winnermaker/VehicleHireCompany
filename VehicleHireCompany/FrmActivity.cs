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

        private void btnOK_Click(object sender, EventArgs e)
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
            if (result == DialogResult.OK)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        protected virtual void UpdateDisplay()
        {
            txtName.Text = _Activity.Name;
            txtValue.Text = _Activity.Value.ToString();
            dtpActivityDate.Value = _Activity.Date;
        
        }
        protected virtual void PushData()
        {
            _Activity.Name = txtName.Text;
            _Activity.Value = Convert.ToDecimal(txtValue.Text);
            _Activity.Date = dtpActivityDate.Value;

        }
    }
}
