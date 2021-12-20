using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            //1. Örnek: Adınızı 100 kez ekrana yazdıran programın algoritmasını yazınız.

            listBox1.Items.Clear();
            for (int i = 1; i <= 100; i++)
            {
                listBox1.Items.Add(i + " UTKU");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //2. Örnek: Ekrana 100 adet yıldız yazdıran programın algoritmasını yazınız.

            listBox1.Items.Clear();
            for (int i = 1; i <= 100; i++)
            {
                listBox1.Items.Add(i + " *");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //3. Örnek: Klavyeden girilen ismi ekrana 10 kez yazdıran programın algoritmasını yazınız.

            string isim = txtIsim.Text;
            listBox1.Items.Clear();
            for (int i = 1; i <= 10; i++)
            {
                listBox1.Items.Add(i + " " + isim);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //4. Örnek: Klavyeden girilen ismi, girilen sayı kadar ekrana yazdıran programın algoritmasını yazınız.

            listBox1.Items.Clear();
            int sayi = int.Parse(txtSayi.Text);
            string isim = txtIsim.Text;
            for (int i = 1; i <= sayi; i++)
            {
                listBox1.Items.Add(i + " " + isim);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //5. Örnek: 1’den 100’e kadar olan sayıları ekrana yazdıran programın algoritmasını yazınız.

            listBox1.Items.Clear();
            for (int i = 1; i <= 100; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //6. Örnek: 0’dan 100’e kadar olan çift sayıları ekrana yazdıran programın algoritmasını yazınız.

            listBox1.Items.Clear();
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 ==0)
                {
                    listBox1.Items.Add(i);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //7. Örnek: 1’den 100’e kadar olan tam sayıların toplamını bulup ekranda gösteren programın algoritmasını yazınız.

            listBox1.Items.Clear();
            int toplam = 0;
            for (int i = 0; i <= 100; i++)
            {
                toplam += i;
            }
            listBox1.Items.Add(toplam);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //8. Örnek: 1’den 50’ye kadar olan çift sayıların toplamını bulup ekranda gösteren programın algoritmasını yazınız.

            listBox1.Items.Clear();
            int toplam = 0;
            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    toplam += i;
                }
            }
            listBox1.Items.Add(toplam);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //9. Örnek: 1’den 100’ye kadar olan tek sayıların toplamını bulup ekranda gösteren programın algoritmasını yazınız.

            listBox1.Items.Clear();
            int toplam = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 1)
                {
                    toplam += i;
                }
            }
            listBox1.Items.Add(toplam);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //10. Örnek: Klavyeden girilen 10 adet sayının toplamını bulup ekranda gösteren programın algoritmasını yazınız.

            listBox1.Items.Clear();
            int rast = rnd.Next(1, 100),toplam = 0;
            for (int i = 1; i <= 10; i++)
            {
                toplam += rast;
            }
            listBox1.Items.Add(toplam);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //11. Örnek: Klavyeden girilen 100 adet sayının toplamını ve ortalamasını bulup ekranda gösteren programın algoritmasını yazınız.

            listBox1.Items.Clear();
            int rast, toplam = 0, ortalama;
            for (int i = 1; i <= 100; i++)
            {
                rast = rnd.Next(1, 100);
                toplam += rast;
            }
            ortalama = toplam / 100;
            listBox1.Items.Add(toplam);
            listBox1.Items.Add(ortalama);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //12. Örnek: Klavyeden girilen 10 adet sayıdan 50’den büyük olanları ekrana yazdıran programın algoritmasını yazınız.

            listBox1.Items.Clear();
            int rast; 
            for (int i = 1; i <= 10; i++)
            {
                rast = rnd.Next(1, 100);
                if (rast > 50)
                {
                    listBox1.Items.Add(rast);
                }       
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //13. Örnek: Klavyeden girilen 10 adet sayıdan 50’den büyük kaç adet sayı olduğunu ekranda gösteren programın algoritmasını yazınız.

            listBox1.Items.Clear();
            int rast,sayac=0;

            for (int i = 1; i <= 10; i++)
            {
                sayac++;
                rast = rnd.Next(1, 100);
                if (rast > 50)
                {
                    
                }
            }
            listBox1.Items.Add(sayac);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //14. Örnek: Klavyeden 40 öğrencinin notları girilecektir. Notların toplamını ve ortalamasını ekranda gösteren programın algoritmasını yazınız. (Girilen notların 0-100 aralığında olup olmadığı kontrol edilmelidir.)

            listBox1.Items.Clear();
            int rast, toplam = 0, ortalama;
            for (int i = 1; i <= 40; i++)
            {
                rast = rnd.Next(0, 101);
                toplam += rast;
                
            }
            ortalama = toplam / 40;
            listBox1.Items.Add(toplam);
            listBox1.Items.Add(ortalama);

        }

        private void button15_Click(object sender, EventArgs e)
        {
            //15. Örnek: 1’den başlayarak klavyeden girilen değere kadar olan sayıları ekranda listeleyen programın algoritmasını yazınız.

            listBox1.Items.Clear();
            int sayi = int.Parse(txtSayi.Text);
            for (int i = 1; i <= sayi; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //16. Örnek: 1’den başlayarak klavyeden girilen değere kadar olan sayıların toplamını ekranda gösteren programın algoritmasını yazınız.

            listBox1.Items.Clear();
            int sayi = int.Parse(txtSayi.Text), toplam = 0;
            for (int i = 0; i < sayi; i++)
            {
                toplam += i;
            }
            listBox1.Items.Add(toplam);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //17. Örnek: Klavyeden girilen 2 sayı arasındaki sayıları ekranda gösteren programın algoritmasını yazınız.

            listBox1.Items.Clear();
            int sayi1 = int.Parse(txtIsim.Text), sayi2 = int.Parse(txtSayi.Text);
            for (int i = sayi1; i < sayi2; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //18. Örnek: İki tam sayının çarpım işlemini sadece toplama işlemi kullanarak gerçekleştiren programın algoritmasını yazınız.

            listBox1.Items.Clear();
            int sayi1 = int.Parse(txtIsim.Text), sayi2 = int.Parse(txtSayi.Text), carpim = 0;
            for (int i = 1; i <= sayi2; i++)
            {
                carpim += sayi1;
            }
            listBox1.Items.Add(carpim);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            //19. Örnek: 20 kişilik sınıfın yaşları girilecektir. Yaşı 18 ile 25 arasında olan çocukların sayısını bulup ekranda gösteren programın algoritmasını yazınız. (18 ve 25 dahil)

            listBox1.Items.Clear();
            int rast, sayac = 0;
            for (int i = 1; i <= 20; i++)
            {
                rast = rnd.Next(1,100);
                if (rast>=18 && rast<=25)
                {
                    sayac++;
                }
            }
            listBox1.Items.Add(sayac);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            //20. Örnek: 5 sayısının faktöriyelini hesaplayıp sonucunu ekranda gösteren programın algoritmasını yazınız.

            listBox1.Items.Clear();
            int sayac = 1, faktoriyel = 1;
            for (int i = 1; i <= 5; i++)
            {
                faktoriyel *= sayac;
                sayac++;
            }
            listBox1.Items.Add(faktoriyel);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            //21. Örnek: Klavyeden girilen sayının faktöriyelini hesaplayan programın algoritmasını yazınız.

            listBox1.Items.Clear();
            int sayac = 1, faktoriyel = 1, sayi = int.Parse(txtSayi.Text);
            for (int i = 0; i < sayi; i++)
            {
                faktoriyel *= sayac;
                sayac++;
            }
            listBox1.Items.Add(faktoriyel);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            //22. Örnek: Klavyeden girilen 20 adet sayının karelerini listeleyen programın algoritmasını yazınız.

            listBox1.Items.Clear();
            int rast, karesi;
            for (int i = 1; i <= 20; i++)
            {
                for (int a = 0; a < 1; a++)
                {
                    karesi = i*i;
                    listBox1.Items.Add(karesi);
                }
       
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            //23. Örnek: 30’dan 100’e kadar olan çift sayıları ekranda gösteren programın algoritmasını yazınız.

            listBox1.Items.Clear();
            for (int i = 30; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    listBox1.Items.Add(i);
                }
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            //24. Örnek: 1’den 100’ye kadar olan çift sayıların toplamını bulup ekranda gösteren programın algoritmasını yazınız.

            listBox1.Items.Clear();
            int toplam = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    toplam += i;
                }
            }
            listBox1.Items.Add(toplam);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            //25. Örnek: 1’den 50’e kadar olan çift sayıların kaç adet olduğunu ve ortalamalarını bulup ekranda gösteren programın algoritmasını yazınız.

            listBox1.Items.Clear();
            int sayac = 0, ortalama, toplam = 0;
            for (int i = 1; i <= 50; i++)
            {
                sayac++;
                if (i % 2 == 0)
                {
                    toplam += i;
                }
                
            }
            ortalama = toplam / 50;
            listBox1.Items.Add(ortalama);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            //26. Örnek: 1’den başlayarak klavyeden girilen sayıya kadar olan tek sayıların toplamını ve ortalamasını ekranda gösteren programın algoritmasını yazınız.

            listBox1.Items.Clear();
            int sayi = int.Parse(txtSayi.Text), toplam = 0, ortalama;
            for (int i = 0; i < sayi; i++)
            {
                if (i % 2 == 1)
                {
                    toplam += 1;
                }
            }
            ortalama = toplam / sayi;
            listBox1.Items.Add(ortalama);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            //27. Örnek: Klavyeden okunan 2 sayı arasındaki sayılardan tek olanları ekranda listeleyen programın algoritmasını yazınız.


        }
    }
}
