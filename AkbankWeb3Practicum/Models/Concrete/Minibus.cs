using AkbankWeb3Practicum.Enum;
using AkbankWeb3Practicum.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkbankWeb3Practicum.Models.Concrete
{
    public class Minibus : Vehicle
    {
        public Minibus()
        {
            TypeOfVehicle = TypeOfVehicle.Minibus;
        }
    }
}
