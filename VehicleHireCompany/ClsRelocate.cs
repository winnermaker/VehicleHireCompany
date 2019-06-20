using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleHireCompany {
    [Serializable]
    public class ClsRelocate : ClsActivity  {
		private int _NumberOfKM;
        private static FrmRelocate _Form = new FrmRelocate();

        public int NumberOfKM { get => _NumberOfKM; set => _NumberOfKM = value; }

        public override string TypeOfActivity()
        {
            return "Relocate";
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
            return base.ToString() + String.Format("|  -{0:C}", Value);
        }
    }

}
