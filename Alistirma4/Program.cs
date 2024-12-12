using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alistirma4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********************* Online Market Teslimat Süresi *********************");

            Console.WriteLine("--------------------------------------------------------------------------");


            Console.WriteLine("Lütfen Siparis Tutarını Giriniz : ");
            decimal tutar = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Lütfen teslimat Mesafesini Giriniz(km) : ");
            decimal mesafe = Convert.ToDecimal(Console.ReadLine());

            Console.Clear();

            int teslimatUcreti = 10;
            decimal ToplamTutar = 0;

            if(mesafe > 0 && mesafe <= 10)
            {
                Console.WriteLine("Mesafeniz" + mesafe);
                Console.WriteLine("Mesafeniz Kısa olduğundan Teslimat Ücreti Ücretsiz. " + " Ücretiniz " + tutar);
            }
            else if(mesafe > 10 && mesafe <=30)
            {
                Console.WriteLine("Mesafeniz" + mesafe);
                ToplamTutar = tutar + teslimatUcreti;

                Console.WriteLine("Teslimatınız 10 km den fazla olduğu için Teslimat Ücretiniz" + teslimatUcreti + "dir.");

                Console.WriteLine("Toplam Tutarınız : " + ToplamTutar);
            }
            else
            {
                if(tutar < 200)
                {
                    Console.WriteLine("30 Km üstü Siparişlerde sipariş Tutarı en az 200 Tl Olmalıdır");
                }
                else
                {
                    teslimatUcreti = 30;

                    Console.WriteLine("Mesafeniz : " + mesafe);
                    ToplamTutar = tutar + teslimatUcreti;

                    Console.WriteLine("Teslimatınız 30 km den fazla olduğu için Teslimat Ücretiniz " + teslimatUcreti + " Tl dir.");

                    Console.WriteLine("Toplam Tutarınız : " + ToplamTutar);
                }
            }
        }
    }
}
