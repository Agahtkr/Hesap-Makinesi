using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        char islem;
        float sonuc;
        bool temizlendiMi = false;
        int a = 0;
        int b = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void rakam1_Click_1(object sender, EventArgs e)
        {
            ekranLabel.Text += "1";
        }

        private void rakam2_Click_1(object sender, EventArgs e)
        {
            ekranLabel.Text += "2";
        }

        private void rakam3_Click_1(object sender, EventArgs e)
        {
            ekranLabel.Text += "3";
        }

        private void rakam4_Click_1(object sender, EventArgs e)
        {
            ekranLabel.Text += "4";
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            ekranLabel.Text += "5";
        }

        private void rakam6_Click_1(object sender, EventArgs e)
        {
            ekranLabel.Text += "6";
        }

        private void rakam7_Click_1(object sender, EventArgs e)
        {
            ekranLabel.Text += "7";
        }

        private void rakam8_Click_1(object sender, EventArgs e)
        {
            ekranLabel.Text += "8";
        }

        private void rakam9_Click_1(object sender, EventArgs e)
        {
            ekranLabel.Text += "9";
        }

        private void rakam0_Click_1(object sender, EventArgs e)
        {
            ekranLabel.Text += "0";
        }

        private void artı_Click_1(object sender, EventArgs e)
        {
            sonuc += Convert.ToInt32(ekranLabel.Text);
            ekranLabel.Text = "";
            islem = '+';
        }

        private void eksi_Click_1(object sender, EventArgs e)
        {
            a++;
            islem = '-';
            if (a == 1 || temizlendiMi)
                sonuc = Convert.ToInt32(ekranLabel.Text);
            else
                sonuc -= Convert.ToInt32(ekranLabel.Text);
            ekranLabel.Text = "";
            temizlendiMi = false;
        }

        private void carpi_Click_1(object sender, EventArgs e)
        {
            a++;
            islem = '*';
            if (a == 1 || temizlendiMi)
                sonuc = Convert.ToInt32(ekranLabel.Text);
            else
                sonuc *= Convert.ToInt32(ekranLabel.Text);
            temizlendiMi = false;
            ekranLabel.Text = "";
        }

        private void bolu_Click_1(object sender, EventArgs e)
        {
            a++;
            islem = '/';
            if (a == 1 || temizlendiMi)
                sonuc = Convert.ToInt32(ekranLabel.Text);
            else
            {
                try
                {
                    sonuc /= Convert.ToInt32(ekranLabel.Text);
                }
                catch (NullReferenceException)
                {
                    ekranLabel.Text = "Matematik henüz o kadar gelişmedi";
                }
            }


            temizlendiMi = false;
            ekranLabel.Text = "";
        }

        private void esittir_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (islem == '+')
                {
                    sonuc += Convert.ToInt32(ekranLabel.Text);
                    ekranLabel.Text = Convert.ToString(sonuc);
                }



                if (islem == '-')
                {
                    sonuc -= Convert.ToInt32(ekranLabel.Text);
                    ekranLabel.Text = Convert.ToString(sonuc);
                }




                if (islem == '*')
                {
                    sonuc *= Convert.ToInt32(ekranLabel.Text);
                    ekranLabel.Text = Convert.ToString(sonuc);
                }


                if (islem == '/')
                {
                    sonuc /= Convert.ToInt32(ekranLabel.Text);
                    ekranLabel.Text = Convert.ToString(sonuc);
                }
            }
            catch (FormatException)
            {
                ekranLabel.Text = ("Sayi girmelisiniz.");
            }
        }

        private void clear_Click_1(object sender, EventArgs e)
        {
            ekranLabel.Text = "";
            sonuc = 0;
            temizlendiMi = true;
        }
    }
}
