using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public /*abstract*/ class Passenger
    {
        public int Id { get; set; }
        public DateTime BirthDate { get; set; }
        
        [StringLength(7)]
        public string PassportNumber { get; set; }
        //[DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string EmailAddress { get; set; }
        // public string FirstName { get; set; }
        // public string LastName { get; set; }

        public FullName FullName { get; set; }

      //  [RegularExpression(@"216"+"^[0-9]{8}$")]
        [RegularExpression(@"^[0-9]{8}$")]
        public string TelNumber { get; set; }
        // prop de navig
        public virtual IList<Flight> Flights { get; set; }

        public override string ToString()
        {
            return "FirstName : " + FullName.FirstName + "LastName : " + FullName.LastName +
              "TelNumber : " + TelNumber + "EmailAdress : " + EmailAddress +
             "PassportNumber : " + PassportNumber;
        }
       public bool CheckProfile(string firstName ,string lastName)
        {
            if(firstName==this.FullName.FirstName && lastName==this.FullName.LastName)
                return true; 
            return false;   
        }
        public bool CheckProfile(string firstName, string lastName,string email)
        {
            if (firstName == this.FullName.FirstName && lastName == this.FullName.LastName && email==this.EmailAddress)
                return true;
            return false;
        }
        public bool CheckProfile2(string firstName, string lastName, string? email = null)
        {
            if (email == null)
            
               return  CheckProfile(firstName, lastName);    
            
            else return CheckProfile(firstName, lastName,email); 
        }
       public  virtual string PassengerType()

        {
            return "I am a passenger";
        }
      //  public abstract string PassengerType2();
       
    }


}
