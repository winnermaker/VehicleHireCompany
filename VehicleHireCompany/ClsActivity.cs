using System;
namespace VehicleHireCompany {
	public abstract class ClsActivity {
        protected string _Name;
        protected string _Type;
        protected DateTime _Date;
        protected decimal _Value;
        public static String[] _ActivityType = {"S","R","H"};


        public static ClsActivity NewActivity(int prChoice) {
			throw new System.Exception("Not implemented");
		}


	}

}
