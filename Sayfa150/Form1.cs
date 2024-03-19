using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayfa150
{
    public partial class Form1 : Form
    {
        Dictionary<int, string> ogrenciler = new Dictionary<int, string>();
        int anahtar;
        string deger;
        private void Listele()
        {
            Ogrenciler.Items.Clear();
            foreach (var ogrenci in ogrenciler)
            {
                Ogrenciler.Items.Add(ogrenci.Key +"-"+ogrenci.Value);
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            anahtar = int.Parse(numara.Text);
            deger = ad.Text;
            ogrenciler.Add(anahtar, deger);
            Listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            anahtar = int.Parse(numara.Text);
            deger = ad.Text;
            ogrenciler[anahtar] = deger;
            Listele();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            anahtar = int.Parse(numara.Text);
            ogrenciler.Remove(anahtar);
            Listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool durum = false;
            if (numara.Text !="")
            {
                anahtar = int.Parse(numara.Text);
                durum = ogrenciler.ContainsKey(anahtar);
            }
            else
            {
                deger = ad.Text;
                durum = ogrenciler.ContainsValue(deger);
            }
            if (durum == true)
            {
                MessageBox.Show("Öğrenci Kayıtlıdır.");
            }
            else
            {
                MessageBox.Show("Öğrenci Kayıtlı Değildir.");
            }
        }
    }
}
