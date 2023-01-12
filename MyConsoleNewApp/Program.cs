using System;

namespace MyConsoleNewApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 1000)
            {
                Console.WriteLine(i + ". Merhaba Ankara");
                i++;
                System.Threading.Thread.Sleep(1000);//1 saniye aralıkla çalıştır
            }
           
        }
    }
}
