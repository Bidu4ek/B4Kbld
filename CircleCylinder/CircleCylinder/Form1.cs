using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircleCylinder
{
    public partial class Form1 : Form
    {
        double R;
        double H;
        double Pl;
        double Dl;
        double Ob;
        string[] REZ = new string[6];
        public Form1()
        {
            InitializeComponent();
            REZ[0] = "Площадь окружности: ";
            REZ[2] = "\r\n\r\nДлина окружности: ";
            REZ[4] = "\r\n\r\nОбъем цилиндра: ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            R = double.Parse(textBox1.Text);
            Circle Circle = new Circle(R);
            Pl = Circle.S();
            Dl = Circle.L();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            H = double.Parse(textBox2.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cylinder Cylinder = new Cylinder(H, Pl);
            Ob = Cylinder.V();
            REZ[1] = Convert.ToString(Pl);
            REZ[3] = Convert.ToString(Dl);
            REZ[5] = Convert.ToString(Ob);
            string one = string.Concat(REZ);
            MessageBox.Show(one);
        }
    }
}
