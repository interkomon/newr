using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract14
{
     class PersonalCar : Car
    {
        private string owner;
        private DateTime proverkacardata;

        public PersonalCar(string number,string brand,string color,int mileage,string owner,DateTime proverkacardata) : base(number,brand,color,mileage)
        {
            this.owner = owner;
            this.proverkacardata = proverkacardata;
        }
        public override string info()
        {
            return $"Номер: {Number} Марка: {Brand} Цвет: {Color} Пробег: {Mileage} Владелец: {owner} Дата техосмотра {proverkacardata} ";
        }

        public string Owner
        {
            get => owner;set => owner = value; 
        }
        public DateTime Proverkacardata
        {
            get => proverkacardata;set => proverkacardata = value;
        }
    }

}
