using System;
namespace VehicleHireCompany {
	public class ClsService : ClsActivity  {
		private string _Workshop;
		private string _Description;

        public string Workshop { get => _Workshop; set => _Workshop = value; }
        public string Description { get => _Description; set => _Description = value; }
    }

}
