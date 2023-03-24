using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract14
{
    abstract public class Car
    {
        private string number;
        private string brand;
        private string color;
        private int mileage;
        

        public Car(string number,string brand,string color,int mileage)
        {
            this.number = number;
            this.brand = brand;
            this.color = color;
            this.mileage = mileage;
        }
        public abstract string info();
     
            public string Number { get => number; set => number = value; }
            public string Brand {get => brand; set => brand = value; }
            public string Color { get => color;set => color = value; }
            public int Mileage { get => mileage; set => mileage = value; }
      

    }


}
