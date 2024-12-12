using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_ELSE_GundelikHayatAlistirma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen Yaşınızı Giriniz : ");
            int yas = Convert.ToInt32(Console.ReadLine());

            if(yas > 0 && yas<=12)
            {
                Console.WriteLine("Çocuk");
            }
            else if(yas > 13 && yas<=19)
            {
                Console.WriteLine("Genç");
            }
            else if(yas > 20 && yas<=64)
            {
                Console.WriteLine("Yetişkin");
            }
            else
            {
                Console.WriteLine("Yaşlı");
            }
        }
    }
}
