using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract14
{
     class CompanyCar:Car
    {
        private string companyName;

        public CompanyCar(string number,string brand,string color,int mileage,string companyName) : base(number,brand,color,mileage)
        {
            this.companyName = companyName;
        }

        public override string info()
        {
            return  $"Номер: {Number} Марка: {Brand} Цвет: {Color} Пробег: {Mileage} Название фирмы {companyName}";
        }
    }
}
