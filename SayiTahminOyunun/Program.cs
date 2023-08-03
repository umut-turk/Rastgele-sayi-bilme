using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SayiTahminOyunun
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("sayı  tahim  edin");

            int tahmin_sayı=int.Parse(Console.ReadLine());

            Random random = new Random();
            int rastgeleSayı = random.Next(1, 6);
            if (tahmin_sayı==rastgeleSayı)
            {
                Console.WriteLine(rastgeleSayı + " " +" idi" +" " +"bildiniz");
            }
            else
            {
                Console.WriteLine(rastgeleSayı + " " + " idi" + " " + "bilemediniz");
            }







            Console.ReadLine();




        }
    }
}
