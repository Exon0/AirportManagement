using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public static class MyExtensions
    {
        public static void UpperFullName(this Passenger pass)
        {
            pass.FullName.FirstName = pass.FullName.FirstName[0].ToString().ToUpper()+pass.FullName.FirstName.Substring(1);
            pass.FullName.LastName = pass.FullName.LastName[0].ToString().ToUpper()+pass.FullName.LastName.Substring(1);    
        }
        public static void AddToCapacity(this Plane plane)
        {
            plane.Capacity = plane.Capacity + 10;
        }
    }
}
