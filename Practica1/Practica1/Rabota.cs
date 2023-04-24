using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Practica1
{
    public partial class Rabota : Form
    {
        public Rabota()
        {
            InitializeComponent();
        }

        
        private void Loc_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                var point = pictureBox1.Location;
                point.X += 65;
                point.Y += 79;                              
                pictureBox1.Location = point;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Font = new Font(textBox1.Font.FontFamily, 20, textBox1.Font.Style);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Gray;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "Флаг США";
            pictureBox1.Image = System.Drawing.Image.FromFile(@"C:\Users\у\Desktop\Practica1\Practica1\jpg\6318253847.jpg");
        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            pictureBox8.Visible = true;
            pictureBox9.Visible = true;
            pictureBox10.Visible = true;

        }

      
    }
  
    
}
