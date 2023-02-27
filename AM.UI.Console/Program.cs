// See https://aka.ms/new-console-template for more information
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Services;

/*#region TP1
Console.WriteLine("Hello, World!");
// constructeur par defaut
Plane plane= new Plane();
plane.Capacity = 10;
Console.WriteLine("plane information  = " + plane.ToString());//cwl + (2*tab)
// constructeur parametré
Plane plane1 = new Plane(150,DateTime.Now,1,PlaneType.Airbus); 
Console.WriteLine("plane1 information  = " + plane1.ToString());
// initialiseur d'objet
Plane plane2 = new Plane { PlaneType= PlaneType.Airbus ,
    ManufactureDate=new DateTime(2023,01,30)};
Console.WriteLine("plane2 information  = " + plane2.ToString());
// test TP1
Passenger p = new Passenger()
{
    BirthDate = new DateTime(2022, 12, 30),
    EmailAddress = "amine@esprit.tn",
    FullName = new FullName()
    {
        FirstName = "tassnime",
        LastName = "kabous"
    },
    PassportNumber ="abc123456",
    TelNumber="+216 53596889",
};
Staff staff = new Staff()
{
    BirthDate = new DateTime(2022, 12, 30),
    EmailAddress = "tassnime@esprit.tn",
    FullName=new FullName()
    {
        FirstName = "tassnime",
        LastName = "kabous"
    },
    PassportNumber = "abc123456",
    TelNumber = "+216 53596889",
    EmployementDate=new DateTime(2022,02,20),
    Function="Capitaine",
    Salary=15000,

};
// cwl +2tab
Console.WriteLine(p.PassengerType());
Console.WriteLine(staff.PassengerType());
#endregion
*///test TP2
ServiceFlight serviceFlight =new ServiceFlight();
serviceFlight.Flights = TestData.listFlights;

/*foreach (Flight ff in serviceFlight.Flights)
{
    Console.WriteLine("Old capacity"+ ff.Plane.Capacity);
    
     ff.Plane.AddToCapacity(); // méthode d'extension

    Console.WriteLine("New capacity" + ff.Plane.Capacity);
}*/
Console.WriteLine("\n----------------------------------------  Ilyes Bettaieb 4SE1 - HomeWork 1 :---------------------------------------------------\n");

Console.WriteLine("\n---------------------------------------- Fonction GetFlightDates---------------------------------------------------\n");
foreach (DateTime ff in serviceFlight.GetFlightDates("Paris"))
{
    Console.WriteLine(ff);
}

Console.WriteLine("\n--------------------------------------- Fonction GetFlights-----------------------------------------------");
serviceFlight.GetFlights("Destination", "Paris");


Console.WriteLine("\n------------------------------ Fonction ShowFlightDetails-------------------------------------\n");
 serviceFlight.ShowFlightDetails(TestData.BoingPlane);

Console.WriteLine("\n-------------------------------- Fonction ProgrammedFlightNumber-------------------------------------------\n");
Console.WriteLine(serviceFlight.ProgrammedFlightNumber(new DateTime(2022, 01, 30, 21, 10, 10)));


Console.WriteLine("\n------------------------------------- Fonction DDurationAverage--------------------------------------\n");
Console.WriteLine(serviceFlight.DurationAverage("Paris"));




Console.WriteLine("\n-------------------------------- Fonction OrderedDurationFlights------------------------------------\n");
foreach (Flight ff in serviceFlight.OrderedDurationFlights())
{
    Console.WriteLine(ff);
}


Console.WriteLine("\n-------------------------------------- Fonction SeniorTravellers----------------------------------------\n");
foreach (Traveller t in serviceFlight.SeniorTravellers(TestData.flight1)) 
{
    Console.WriteLine(t);
}

Console.WriteLine("\n------------------------------ Fonction DestinationGroupedFlights---------------------------------------");
serviceFlight.DestinationGroupedFlights();



