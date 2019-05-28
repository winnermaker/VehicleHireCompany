using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleHireCompany {
    [Serializable]
    public abstract class ClsActivity {
        private string _Name;        
        private DateTime _Date = DateTime.Now;
        private decimal _Value;
        private static String[] _ActivityType = {"Hire","Service","Relocate"};

        public string Name { get => _Name; set => _Name = value; }
        public DateTime Date { get => _Date; set => _Date = value; }
        public decimal Value { get => _Value; set => this._Value = value; }
        public static string[] ActivityType { get => _ActivityType; set => _ActivityType = value; }

        public static ClsActivity NewActivity(int prChoice)
        {
            switch (prChoice)
            {
                case 0:
                    return new ClsHire();
                case 1:
                    return new ClsService();
                default:
                    return new ClsRelocate();
            }
        }

        public abstract Boolean ViewEdit();

        public abstract string TypeOfActivity();

        public override string ToString()
        {
            return String.Format("{0,-20}\t\t|  {1,-20}\t|  {2,-20}\t|  {3:C}", _Name, TypeOfActivity(), _Date.ToShortDateString(), _Value);
        }
	}
}
