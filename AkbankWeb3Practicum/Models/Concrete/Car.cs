using AkbankWeb3Practicum.Enum;
using AkbankWeb3Practicum.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkbankWeb3Practicum.Models.Concrete
{
    public class Car :Vehicle
    {
        public Car()
        {
            TypeOfVehicle = TypeOfVehicle.Car;
        }
    }
}
