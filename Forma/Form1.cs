using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using pract14;


namespace Forma
{
    public partial class Form1 : Form
    {
       private  List<Car> cars = new List<Car>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            button3.Visible = false;
            button2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex regex1 = new Regex("^[а-яА-Я]");
            Regex regex12 = new Regex("^[А-Я]{1}[0-9]{3}[А-Я]{2}[0-9]{2,3}");
            Regex regex2 = new Regex("^[0-10]");
            if (tabControl1.SelectedIndex == 0)
            {

                string number = textBox1.Text;
                string brand = textBox2.Text;
                string color = textBox3.Text;
                int mileage = int.Parse(textBox4.Text);
                string owner = textBox5.Text;
                if (!regex12.IsMatch(textBox1.Text))
                {
                    MessageBox.Show("Введен неверный номер", "Ошибка");
                }
                else
                if(!regex1.IsMatch(textBox2.Text))
                {
                    MessageBox.Show("Бренд состоит из букв", "Ошибка");
                }
                else
                if(!regex1.IsMatch(textBox3.Text))
                {
                    MessageBox.Show("Цвет состоит из букв", "Ошибка");
                }
                else
                if(regex2.IsMatch(textBox4.Text))
                {
                    MessageBox.Show("Пробег состоит из цифр", "Ошибка");
                }
                else
                if(!regex1.IsMatch(textBox5.Text))
                {
                    MessageBox.Show("Владелец состоит из букв", "Ошибка");
                }
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox5.Text == "" || textBox4.Text.ToString() == "")
                {
                    MessageBox.Show("Введите все значения", "Ошибка");
                }
                else
                {
                    DateTime proverkacardata = dateTimePicker1.Value;
                    PersonalCar personalCar = new PersonalCar(number, brand, color, mileage, owner, proverkacardata);
                    cars.Add(personalCar);
                }
            }
            else if(tabControl1.SelectedIndex == 1)
            {
                string number = textBox13.Text;
                string brand = textBox14.Text;
                string color = textBox15.Text;
                int mileage = int.Parse(textBox16.Text);
                string companyName = textBox18.Text;
                if(!regex12.IsMatch(textBox13.Text))
                {
                    MessageBox.Show("Введен неверный номер", "Ошибка");
                }
                else
                if(!regex1.IsMatch(textBox14.Text))
                {
                    MessageBox.Show("Бренд состоит из букв", "Ошибка");
                }
                else
                if(!regex1.IsMatch(textBox15.Text))
                {
                    MessageBox.Show("Цвет состоит из букв", "Ошибка");
                }
                else
                if (regex2.IsMatch(textBox16.Text))
                {
                    MessageBox.Show("Пробег состоит из цифр", "Ошибка");
                }
                else
                if (!regex1.IsMatch(textBox18.Text))
                {
                    MessageBox.Show("Название компании состоит из букв", "Ошибка");
                }
                else
                if (textBox13.Text == "" || textBox14.Text == "" || textBox15.Text == "" || textBox18.Text == "" || textBox16.Text.ToString() == "")
                {
                    MessageBox.Show("Введите все значения", "Ошибка");
                }
                else
                {
                    CompanyCar companyCar = new CompanyCar(number, brand, color, mileage, companyName);
                    cars.Add(companyCar);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            StreamWriter sw = new StreamWriter("carss.txt");
                foreach(var car in cars)
            {
                sw.WriteLine(car.info());
            }
            sw.Close();
            button3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;
            
            StreamReader sr = new StreamReader("carss.txt");
            listBox1.Items.Clear();
            while(!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                listBox1.Items.Add(line);
            }
            sr.Close();
            


        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы уверены что добавили все автомобили? Если да, то нажмите еще раз сохранить и нажмите выгрузить. Если нет - Сначало добавте все автомобили, после этого нажимайте только эту кнопку.", "Помощь");
            button4.Visible = false;
            button2.Visible = true;
        }
    }
}
