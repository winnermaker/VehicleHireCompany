using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleHireCompany
{
    sealed class ClsDateComparer : IComparer<ClsActivity>
    {
        private ClsDateComparer() { }
        public static readonly ClsDateComparer Instance = new ClsDateComparer();
        public int Compare(ClsActivity a, ClsActivity b)
        {
            return a.Date.CompareTo(b.Date);
        }
    }
}
