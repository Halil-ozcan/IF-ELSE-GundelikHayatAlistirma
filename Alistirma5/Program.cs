using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alistirma5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************** Araç Sigorta Ücreti Hesaplama ******************");
            Console.WriteLine("------------------------------------------------------------------------");

            Console.WriteLine("Lütfen Araç Türünü Giriniz");
            Console.WriteLine("1 - Otomobil ");
            Console.WriteLine("2 - Motosiklet ");
            Console.WriteLine("3 - Ticari ");
            Console.Write("seciniz : ");
            string AracTuru = Console.ReadLine();

            Console.Clear();

            
            int Otomobil = 1000;
            int Motor = 500;
            int Ticari = 2000;
            int toplam;
            int yas = 0;
            if (AracTuru == "1" || AracTuru == "2" || AracTuru == "3")
            {
                Console.WriteLine("Lütfen Yaşınızı Giriniz");
                 yas = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Hatalı Bir Seçim Yaptınız");
            }

            if(AracTuru == "1")
            {
                toplam = Otomobil + yas * 20;

                Console.WriteLine("Toplam Sigorta : " + toplam);
            }
            else if(AracTuru == "2")
            {
                toplam = Motor + yas * 10;

                Console.WriteLine("Toplam Sigorta : " + toplam);
            }
            else if(AracTuru == "3")
            {
                toplam = Ticari + yas * 30;

                Console.WriteLine("Toplam Sigorta : " + toplam);
            }
        }
    }
}
