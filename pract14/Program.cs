using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace pract14
{
    internal class Program
    {

        static void Main(string[] args)
        {
            try

            {
                List<Car> spisok = new List<Car>();
                //PersonalCar myCar = null;
                // CompanyCar companyCar = null;
                bool end = false;
                do
                {
                    Console.WriteLine("1 - добавить личный автомобиль");
                    Console.WriteLine("2 - добавить автомобиль фирмы");
                    Console.WriteLine("0 - закончить ввод");
                    int znach = int.Parse(Console.ReadLine());

                    switch (znach)
                    {
                        case 0:
                            end = true;
                            break;

                        case 1:
                            Console.WriteLine("~ЛИЧНЫЙ АВТОМОБИЛЬ~");
                            Console.Write("Введите номер: ");
                            string number = Console.ReadLine();
                            Console.Write("Введите марку: ");
                            string brand = Console.ReadLine();
                            Console.Write("Введите цвет: ");
                            string color = Console.ReadLine();
                            Console.Write("Введите пробег: ");
                            int mileage = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Введите фамилию владельца: ");
                            string owner = Console.ReadLine();
                            Console.Write("Введите дату техосмотра(ДД.ММ.ГГГГ): ");
                            DateTime proverkacardata = Convert.ToDateTime(Console.ReadLine());

                            spisok.Add(new PersonalCar(number, brand, color, mileage, owner, proverkacardata));
                            Console.WriteLine();
                            break;

                        case 2:

                            Console.WriteLine("~АВТОМОБИЛЬ ФИРМЫ~");
                            Console.Write("Введите номер: ");
                             number = Console.ReadLine();
                            Console.Write("Введите марку: ");
                            brand = Console.ReadLine();
                            Console.Write("Введите цвет: ");
                             color = Console.ReadLine();
                            Console.Write("Введите пробег: ");
                             mileage = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Введите дату техосмотра(ДД.ММ.ГГГГ): ");
                             proverkacardata = Convert.ToDateTime(Console.ReadLine());
                            Console.Write("Введите название фирмы: ");
                            string companyName = Console.ReadLine();
                            spisok.Add(new CompanyCar(number, brand, color, mileage, companyName));
                            break;
                        default:
                            Console.WriteLine("Введен неправильный номер");
                            break;

                    }
                    Console.WriteLine();
                } while (!end);
                StreamWriter sw = new StreamWriter("cars.txt");
                foreach(Car car in spisok)
                {
                    sw.WriteLine(car.info());
                }
                sw.Close();
                Console.ReadKey();

            }
            catch
            {
                Console.WriteLine("Ошибка. Проверьте ввод");
                Console.ReadKey();

            }


        }
   

    }
} 
