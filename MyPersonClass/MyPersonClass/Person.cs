using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPersonClass
{
    public class Person
    {
        public string Age(int year, int month) 
        {   
            int age = DateTime.Now.Year - year;

            if (DateTime.Now.Month < month)
            {
                age -= 1;
            }

            if (age < 9 & age > 0)
            {
                MessageBox.Show("Тебе ?" + age );
            }

            if (age < 0)
            {
                MessageBox.Show("Тебе ?" + age );
            }
            return Convert.ToString(age);
        }

        public void Output(string firstName, string lastName, string age) 
        {
            if (firstName == "" || lastName == "" || firstName == "Имя" || lastName == "Фамилия")
            {
                MessageBox.Show("Заплните данные");
            }
            else
            {
                MessageBox.Show("Имя: " + firstName + "" +
                      "\n" + "Фамилия: " + lastName + "" +
                      "\n" + "Возраст: " + age);
            }
        }
    }
}
