using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mnogoulnic
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void BTN_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // 1. Объявить экземпляр типа GraphicsPath - класс биб-лиотеки .NET Framework,
            // который устанавливает последовательность соединенных линий и кривых.
            System.Drawing.Drawing2D.GraphicsPath gp = new
                System.Drawing.Drawing2D.GraphicsPath();

            // 2. Создать массив точек, соответствующих координатам
            //    пятиугольника, образовывающего форму.
            // 2.1. Объявить экземпляр типа "массив точек Point[]".
            //    Point - это класс, который описывает точку на экране.
            Point[] mp = new Point[10];

            // 2.2. Выделить память для каждой точки и заполнить
            //         ее значениями.
            mp[0] = new Point(340, 0);
            mp[1] = new Point(180, 138);
            mp[2] = new Point(61, 151);
            mp[3] = new Point(169, 225);
            mp[4] = new Point(98, 311);
            mp[5] = new Point(255, 263);
            mp[6] = new Point(400, 327);
            mp[7] = new Point(353, 187);
            mp[8] = new Point(455, 95);
            mp[9] = new Point(338, 82);

            // 3. Добавить массив точек Point[] в экземпляр gp
            gp.AddPolygon(mp);

            // 4. Создать область (Region) на основе последователь-ности точек gp
            Region rg = new Region(gp);

            // 5. Установить область формы this.Region
            //       в новое значение rg
            this.Region = rg;

        }
    }
}
