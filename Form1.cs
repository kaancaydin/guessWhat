using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odevB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sayac = 0;
        int sayi;
        int sifir = 0;
        


        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            Random random = new Random();
            sayi = random.Next(1, 101);
            label7.Text = sayi.ToString();
            MessageBox.Show("Bilgisayar sayısını tuttu. Tahmin etmek için yazı kısmına yazın.", "Başla!");
            label9.Text = "";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int tahmin = Convert.ToInt32(textBox1.Text);



            if (tahmin == sayi)
            {
                MessageBox.Show("Tebrikler, bildiniz!","Doğru!");
                label5.Text = sayac.ToString();
                button2.Enabled = false;
                textBox1.Clear();
                label5.Text = sifir.ToString();
                label9.Text = sayac.ToString() + " denemede bildiniz";
                
            }

            if (tahmin > sayi)
            {
                sayac++;
                label5.Text = sayac.ToString();
                MessageBox.Show("tahmininiz sayıdan büyüktür. düşük sayılar deneyin.", "Yanlış!");
            }

            if (tahmin < sayi)
            {
                sayac++;
                label5.Text = sayac.ToString();
                MessageBox.Show("tahmininiz sayıdan küçüktür. büyük sayılar deneyin.","Yanlış!");
            }

            if (tahmin > 101)
            {
                
                MessageBox.Show("ups, galiba bir yanlışlık oldu. lütfen 100ün altında değer girin.", "Hata!");

            }

            if (tahmin < 1)
            {

                MessageBox.Show("ups, galiba bir yanlışlık oldu. lütfen 1in üstünde değer girin.", "Hata!");

            }

        }
    }
}
