using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleHireCompany {
    [Serializable]
    public class ClsService : ClsActivity  {
		private string _Workshop;
		private static FrmService _Form = new FrmService();

        public string Workshop { get => _Workshop; set => _Workshop = value; }
        
        public override string TypeOfActivity()
        {
            return "Service";
        }

        public override bool ViewEdit()
        {
            return _Form.ShowDialog(this);
        }

        public override decimal CalculateValue(decimal prValue)
        {
            return prValue;
        }


        public override string ToString()
        {
            return base.ToString() + String.Format("|  -{0:C}",Value);
        }
    }

}
