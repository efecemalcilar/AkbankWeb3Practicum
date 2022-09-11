using AkbankWeb3Practicum.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkbankWeb3Practicum.Models.Abstract
{
    public abstract class Vehicle
    {
        public int Id { get; set; }
        public int HgsNo { get; set; }
        public string OwnerFirstname { get; set; }
        public string OwnerLastName { get; set; }
        public TypeOfVehicle TypeOfVehicle { get; set; }
        public DateTime Date { get; set; }
        public int Balance { get; set; }
    }
}
