using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DemoMVVM.Data
{
    public class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }


        public static Vehicle[] GetVehicles()
        {
            var vehicles = new Vehicle[]
            {
                new Vehicle() { Brand = "ЗАЗ", Model = "Таврия", Year = 2004 },
                new Vehicle() { Brand = "Chevrovet", Model = "Aveo", Year = 2006 },
                new Vehicle() { Brand = "Kia", Model = "Ceed", Year = 2008 },
                new Vehicle() { Brand = "Honda", Model = "Accord", Year = 2011 },
                new Vehicle() { Brand = "Nissan", Model = "X-Trail", Year = 2015 }
            };

            return vehicles;
        }



    }
}
