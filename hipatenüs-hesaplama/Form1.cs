using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hipatenüs_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Hesapla_Click(object sender, EventArgs e)
        {
            double k1, k2, sonuc;
            k1=Convert.ToDouble(textBox1.Text);
            k2= Convert.ToDouble(textBox2.Text);
            sonuc=Math.Sqrt((Math.Pow(k1,4) + Math.Pow(k2, 2)));
            label1.Text=sonuc.ToString();
             

        }
    }
}
