using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FonaNama
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        public double sislo = 0.927465381;
        public int count;
        public int[] X;
        public int[] Y;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //sislo = FoneNeiMan(sislo);
            sislo = r.NextDouble();//* 0.927465381;
            //MessageBox.Show(sislo.ToString());
            count = Convert.ToInt32(textBox1.Text);
            //
            X = new int[count]; Y = new int[count];
            for (int i = 0; i < count; i++)
            {
                sislo = FoneNeiMan(sislo);
                X[i] = (int)(sislo * count);
            }
            //
            chart1.Series["Series1"].Points.DataBindXY(Y, X);

        }
        char[] newFon;
        string nstrfor;
        double neewFon;
        public double FoneNeiMan(double last)
        {
            newFon = (last * last).ToString().ToCharArray();
            nstrfor = "0," + ((newFon.Length >= 5) ? newFon[4] : '0') +
                ((newFon.Length >= 6) ? newFon[5] : '0') +
                ((newFon.Length >= 7) ? newFon[6] : '0') +
                ((newFon.Length >= 8) ? newFon[7] : '0');
            //neewFon = Convert.ToDouble(nstrfor);
            //MessageBox.Show(neewFon.ToString());
            neewFon = Convert.ToDouble(Math.Floor(Convert.ToDecimal(last) * Convert.ToDecimal(last) * 1e6M) / 1e4M % 1);
            return neewFon;
        }
    }
}
