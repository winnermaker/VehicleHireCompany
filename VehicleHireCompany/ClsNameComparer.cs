using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleHireCompany
{
    sealed class ClsNameComparer : IComparer<ClsActivity>
    {
        private ClsNameComparer() { }
        public static readonly ClsNameComparer Instance = new ClsNameComparer();


        public int Compare(ClsActivity a, ClsActivity b)
        {
            string lcNameA = a.Name;
            string lcNameB = b.Name;

            return lcNameA.CompareTo(lcNameB);
        }
    }
}
