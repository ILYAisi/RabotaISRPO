using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPersonClass
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void View_Click(object sender, EventArgs e)
        {
            string firstName = name.Text;
            string lastName = surname.Text;
            int year = date.Value.Year;
            int month = date.Value.Month;

            Person person = new Person();

            string age = person.Age(year, month);
            person.Output(firstName, lastName, age);
        }


        private void Name_Click(object sender, EventArgs e)
        {
            name.Text = "";
        }

        private void Surname_Click(object sender, EventArgs e)
        {
            surname.Text = "";
        }

        
    }
}
