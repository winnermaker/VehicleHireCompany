using System;
namespace VehicleHireCompany {
	public class ClsVehicle {
		private string _Model;
		private int _Year;
		private decimal _DailyHireCharge;
		private String _RegistrationNumber;

        public string Model { get => _Model; set => _Model = value; }
        public int Year { get => _Year; set => _Year = value; }
        public decimal DailyHireCharge { get => _DailyHireCharge; set => _DailyHireCharge = value; }
        public String RegistrationNumber { get => _RegistrationNumber; set => _RegistrationNumber = value; }
    }

}
