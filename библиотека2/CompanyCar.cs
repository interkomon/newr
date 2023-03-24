using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract14
{
    public class CompanyCar:Car
    {
        private string companyName;

        public CompanyCar(string number,string brand,string color,int mileage,string companyName) : base(number,brand,color,mileage)
        {
            this.companyName = companyName;
        }

        public override string info()
        {
            return  $"Номер: {Number} Марка: {Brand} Цвет: {Color} Пробег: {Mileage} Название фирмы: {companyName}";
        }

        public string CompanyName
        {
            get => CompanyName;set=> companyName = value; 
        }
    }
}
