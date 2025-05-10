using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormdaCafeSiparişUygulaması
{
    public partial class Form1 : Form
    {

        int su = 0, cay = 0, kahve = 0, kola = 0, soda = 0, limonata = 0;

        private void butSodaArti_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(labelSoda.Text);
            sayi++;
            soda = sayi;
            labelSoda.Text = soda.ToString();
        }
        private void butSodaEksi_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(labelSu.Text);
            if (soda > 0)
            {
                sayi--;
                soda = sayi;
                labelSoda.Text = soda.ToString();
            }
        }

        private void butLimonArti_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(labelLimonata.Text);
            sayi++;
            limonata = sayi;
            labelLimonata.Text = limonata.ToString();
        }
        private void butLimonEksi_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(labelSu.Text);
            if (limonata > 0)
            {
                sayi--;
                limonata = sayi;
                labelLimonata.Text = limonata.ToString();
            }
        }

        private void butKolaArti_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(labelKola.Text);
            sayi++;
            kola = sayi;
            labelKola.Text = kola.ToString();
        }
        private void butKolaEksi_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(labelSu.Text);
            if (kola > 0)
            {
                sayi--;
                kola = sayi;
                labelKola.Text = kola.ToString();
            }
        }

        private void butKahveArti_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(labelKahve.Text);
            sayi++;
            kahve = sayi;
            labelKahve.Text = kahve.ToString();
        }
        private void butKahveEksi_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(labelSu.Text);
            if (kahve > 0)
            {
                sayi--;
                kahve = sayi;
                labelKahve.Text = kahve.ToString();
            }
        }
        private void butCatArti_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(labelCay.Text);
            sayi++;
            cay = sayi;
            labelCay.Text = cay.ToString();
        }

        private void butCayEksi_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(labelSu.Text);
            if (cay > 0)
            {
                sayi--;
                cay = sayi;
                labelCay.Text = cay.ToString();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void butSuArti_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(labelSu.Text);
            sayi++;
            su = sayi;
            labelSu.Text = su.ToString();
        }
        private void butSuEksi_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(labelSu.Text);
            if (su > 0)
            {
                sayi--;
                su = sayi;
                labelSu.Text = su.ToString();
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            su = 0;
            cay = 0;
            kahve = 0;
            kola = 0;
            soda = 0;
            limonata = 0;

            labelCay.Text = "0";
            labelSu.Text = "0";
            labelKahve.Text = "0";
            labelLimonata.Text = "0";
            labelKola.Text = "0";
            labelSoda.Text = "0";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("Toplam Siparişleriniz\nSu:{0}\nÇay:{1}\nKahve:{2}\nKola:{3}\nSoda:{4}\nLimonata:{5}\n",su,cay,kahve,kola,soda,limonata));
        }

        public Form1()
        {
            InitializeComponent();
        }


    }
}
