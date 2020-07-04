using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }


        public Car(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }
    }
}
