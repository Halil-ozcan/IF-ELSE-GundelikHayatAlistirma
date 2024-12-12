using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alistirma2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************** Kredi Kartı Ödeme Sistemi *****************");

            Console.Write("Kredi Kartı Borcunuzu Giriniz : ");
            decimal borc = Convert.ToDecimal(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Borcunuz : " + borc);
            Console.WriteLine("Ödenecek Turarı Giriniz : ");
            decimal odeme = Convert.ToDecimal(Console.ReadLine());
            Console.Clear();

            decimal kalan = borc - odeme;

            if (kalan == 0)
            {
                Console.WriteLine("Teşekkür ederiz Borcunuz Kalmadı.");
            }
            else if (odeme > borc / 2)
            {
                Console.WriteLine("Kalan Borcunuz : " + kalan + " Tl ");
            }
            else
            {
                Console.WriteLine("Kalan Borcunuz : " + kalan + " Tl ");
                Console.WriteLine("Lütfen kalan borcunuzu en kısa sürede ödeyin");
            }
        
        }
    }
}
