using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Flight
    {
        public string Destination { get; set; }
        public string Departure { get; set; }
        public DateTime FlightDate { get; set; }
        public int FlightId { get; set; }
        public DateTime EffectiveArrival { get; set; }
        public int EstimatedDuration { get; set; }
        public string AirlineLogo { get; set; }
        public int? PlaneFk { get; set; }//? : nillable
        //prop de navig
        [ForeignKey("PlaneFk")]
        public virtual Plane Plane { get; set; }  
        
        public virtual IList<Passenger> Passengers { get; set;}

        public override string ToString()
        {
     
            return "\nDestination : " + Destination + " -- FlightDate : " + FlightDate +
            " -- Departure : " + Departure + " -- EffectiveArrival : " + EffectiveArrival +
             "  --  EstimatedDuration : " + EstimatedDuration;
        
    }
    }
}
