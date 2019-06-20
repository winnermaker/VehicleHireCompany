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
            if (ActivityList != null)
            {
                int count = 0;
                foreach (ClsActivity lcActivity in ActivityList)
                {
                    switch (lcActivity.TypeOfActivity())
                    {
                        case "Hire":
                            ClsHire hire = (ClsHire)ActivityList[count];
                            hire.Value = hire.CalculateValue(DailyHireCharge);
                            lcTotal += lcActivity.Value;
                            break;
                        case "Relocate":
                            ClsRelocate relocate = (ClsRelocate)ActivityList[count];
                            relocate.Value = relocate.CalculateValue(lcActivity.Value);
                            lcTotal -= lcActivity.Value;
                            break;
                        default:
                            ClsService service = (ClsService)ActivityList[count];
                            service.Value = service.CalculateValue(lcActivity.Value);
                            lcTotal -= lcActivity.Value;
                            break;
                    }

                    count++;
                }
            }
            return lcTotal;
        }

    }

}
