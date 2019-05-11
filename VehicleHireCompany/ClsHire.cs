using System;
namespace VehicleHireCompany {
	public class ClsHire : ClsActivity  {
		private string _CustName;
		private DateTime _StartDate;
		private DateTime _EndDate;

        public string CustName { get => _CustName; set => _CustName = value; }
        public DateTime StartDate { get => _StartDate; set => _StartDate = value; }
        public DateTime EndDate { get => _EndDate; set => _EndDate = value; }

        public decimal CalculateCost(DateTime prStart, DateTime prEnd, decimal prDailyCharge) {
			throw new System.Exception("Not implemented");
		}

		

	}

}
