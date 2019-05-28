using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleHireCompany {
    [Serializable]
    public class ClsVehicle {
		private string _Model;
        private string _Make;
        private int _Year = 2000;
		private decimal _DailyHireCharge;
		private String _RegistrationNumber;
        private List<ClsActivity> _ActivityList = new List<ClsActivity>();       

        public string Model { get => _Model; set => _Model = value; }
        public int Year { get => _Year; set => _Year = value; }
        public String RegistrationNumber { get => _RegistrationNumber; set => _RegistrationNumber = value; }
        public List<ClsActivity> ActivityList { get => _ActivityList; }
        public string Make { get => _Make; set => _Make = value; }
        public decimal DailyHireCharge { get => _DailyHireCharge; set => _DailyHireCharge = value; }

        public decimal TotalValue()
        {
            decimal lcTotal = 0;
            if (_ActivityList != null)
            {
                foreach (ClsActivity lcActivity in _ActivityList)
                {
                    lcTotal += lcActivity.Value;
                }
            }
            return lcTotal;
        }

        public void SortList(bool SortOrder)
        {
            if (!SortOrder)
            {
                ActivityList.Sort(ClsNameComparer.Instance);
            }
            else
            {
                ActivityList.Sort(ClsDateComparer.Instance);
            }

        }

    }

}
