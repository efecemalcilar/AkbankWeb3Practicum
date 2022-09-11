using AkbankWeb3Practicum.Models;
using AkbankWeb3Practicum.Models.Abstract;
using AkbankWeb3Practicum.Models.Concrete;

namespace AkbankWeb3Practicum
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Int64 hgsNo = 0;
            Counter gise = new Counter();
            DailyEarning earn = new DailyEarning();
            Car car = new Car();
            Minibus minibus = new Minibus();
            Bus bus = new Bus();

            car.HgsNo = 123456789;
            car.OwnerFirstname = "Jack";
            car.OwnerLastName = "Sparrow";
            //car.TypeOfVehicle = "Car";

            minibus.HgsNo = 123456788;
            minibus.OwnerFirstname = "Anthony";
            minibus.OwnerLastName = "Davis";
            //minibus.TypeOfVehicle = "Minibus";

            bus.HgsNo = 123456787;
            bus.OwnerFirstname = "Lebron";
            bus.OwnerLastName = "James";
            //bus.TypeOfVehicle = "Bus";




            while (true)
            {
                Console.WriteLine("Select the class of the vehicle to pass:");
                Console.WriteLine("1-Car \n2-Minibüs \n3-Bus \n4-Print Daily Earnings");

                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Vehicle Owner:" + car.OwnerFirstname + " " + car.OwnerLastName);
                        Console.WriteLine("Vehicle class of your choice Car and Hgs No: " + car.HgsNo);
                        hgsNo = car.HgsNo;
                        gise.Payment(hgsNo);
                        earn.Earning(hgsNo);
                        break;
                    case 2:
                        Console.WriteLine("Vehicle Owner:" + minibus.OwnerFirstname + " " + minibus.OwnerLastName);
                        Console.WriteLine("Vehicle class of your choice Minibüs and Hgs No: " + minibus.HgsNo);
                        hgsNo = minibus.HgsNo;
                        gise.Payment(hgsNo);
                        earn.Earning(hgsNo);
                        break;
                    case 3:
                        Console.WriteLine("Vehicle Owner:" + bus.OwnerFirstname + " " + bus.OwnerLastName);
                        Console.WriteLine("Vehicle class of your choice Bus and Hgs No: " + bus.HgsNo);
                        hgsNo = bus.HgsNo;
                        gise.Payment(hgsNo);
                        earn.Earning(hgsNo);
                        break;
                    case 4:
                        earn.PrintTheGain();
                        hgsNo = 0;
                        break;
                }
            }
        }
    }
}