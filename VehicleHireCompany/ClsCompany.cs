using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace VehicleHireCompany {
	public class ClsCompany {
        private static SortedDictionary<String, ClsVehicle> _VehicleList = new SortedDictionary<string, ClsVehicle>();
        private const string fileName = "hireCompany.dat";

        public static SortedDictionary<string, ClsVehicle> VehicleList { get => _VehicleList;}

        public static void Save()
        {
            System.IO.FileStream lcFileStream = new System.IO.FileStream(fileName, System.IO.FileMode.Create);
            BinaryFormatter lcFormatter = new BinaryFormatter();
            lcFormatter.Serialize(lcFileStream, _VehicleList);
            lcFileStream.Close();            
        }

        public static void Retrieve()
        {            
            System.IO.FileStream lcFileStream = new System.IO.FileStream(fileName, System.IO.FileMode.Open);
            BinaryFormatter lcFormatter = new BinaryFormatter();
            _VehicleList = (SortedDictionary<string, ClsVehicle>)lcFormatter.Deserialize(lcFileStream);                
            lcFileStream.Close();            
        }       

        
        public static decimal TotalValue()
        {
            decimal lcTotal = 0;
            foreach (ClsVehicle lcVehicle in _VehicleList.Values)
                lcTotal += lcVehicle.TotalValue();
            return lcTotal;
        }

    }

}
