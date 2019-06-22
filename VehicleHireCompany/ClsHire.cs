using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleHireCompany {
    [Serializable]
    public class ClsHire : ClsActivity  {
		private string _CustName;
		private DateTime _EndDate = DateTime.Now;
        private static FrmHire _Form = new FrmHire();

        public string CustName { get => _CustName; set => _CustName = value; }       
        public DateTime EndDate { get => _EndDate; set => _EndDate = value; }

        public override Boolean ViewEdit()
        {            
            return _Form.ShowDialog(this);
        }

        public override string TypeOfActivity()
        {
            return "Hire";
        }

        public override decimal CalculateValue(decimal prHireCharge)
        {
            decimal days = Convert.ToDecimal((_EndDate - Date).TotalDays + 1);
            return days * prHireCharge;
        }

        public override string ToString()
        {
            return base.ToString() + String.Format("|   {0:C}", Value);
        }
    }

}
