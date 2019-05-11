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
        private FrmActivityLog _ActivityForm = new FrmActivityLog();
        public FrmVehicle()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }

        private void btnCamcel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnActivity_Click(object sender, EventArgs e)
        {
            _ActivityForm.Show();
        }
    }
}