using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alistirma_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************** İndirimli Ürün Mağzasına Hoş Geldiniz ******************");
            Console.WriteLine("------------------------------------------------------------------------");

            Console.WriteLine("Lütfen Müşteri Türünü Giriniz");
            Console.WriteLine("1 - Standart ");
            Console.WriteLine("2 - Öğrenci ");
            Console.WriteLine("3 - Üyelik ");
            Console.Write("seciniz : ");
            string musteriTuru = Console.ReadLine();

            Console.Clear();


            decimal tutar = 0;
            decimal fiyat = 0;

            if(musteriTuru == "1" || musteriTuru == "2" || musteriTuru == "3")
            {
                Console.WriteLine("Lütfen Alacağınız Ürünün Fiyatini Girin");
                fiyat = Convert.ToDecimal(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Hatalı Bir Seçim Yaptınız");
            }

            if(musteriTuru == "1")
            {
                Console.WriteLine("Standart Müşterilerimize İndirim Oranı Bulunmamaktadır. " + fiyat + " TL ");
            }
            else if(musteriTuru == "2")
            {
                tutar = (fiyat * 20) / 100;

                Console.WriteLine("Öğrencilerimize Yüzde 20 İndirimimiz Bulunmaktadır. " + tutar + " TL ");
            }
            else
            {
                tutar = (fiyat * 10) / 100;
                Console.WriteLine("Üyelik Sahibi Müşterilerimize Yüzde 10 İndirimimiz Bulunmaktadır. " + tutar + " TL ");
            }
            
        }
    }
}
