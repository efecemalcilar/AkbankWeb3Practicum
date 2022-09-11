using AkbankWeb3Practicum.Models.Abstract;
using AkbankWeb3Practicum.Models.Concrete;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkbankWeb3Practicum.Models
{
    public class Counter
    {
        public int CarPay = 50;
        public int MinibusPay = 75;
        public int BusPay = 100;

        public int CarBalance = 1500;
        public int MinibusBalance = 2500;
        public int BusBalance = 3000;

        ArrayList vehicles = new ArrayList();


        public void Payment(Int64 HgsNo)
        {
            Car car = new Car();
            Minibus minibus = new Minibus();
            Bus bus = new Bus();

            car.Balance = CarBalance;
            minibus.Balance = MinibusBalance;
            bus.Balance = BusBalance;

            if (HgsNo == 123456789)
            {
                CarBalance -= CarPay;
                car.Balance = CarBalance;
                Console.WriteLine("The date and time the car passed: " + DateTime.Now + " and Current Balance: " + car.Balance);
            }
            else if (HgsNo == 123456788)
            {
                MinibusBalance -= MinibusPay;
                minibus.Balance = MinibusBalance;
                Console.WriteLine("The date and time the Minibus passed: " + DateTime.Now + " and Current Balance: " + minibus.Balance);
            }
            else if (HgsNo == 123456787)
            {
                BusBalance -= BusPay;
                bus.Balance = BusBalance;
                Console.WriteLine("The date and time the Bus passed: " + DateTime.Now + " and Current Balance: " + bus.Balance);
            }


            vehicles.Add(HgsNo);
        }
    }
}
