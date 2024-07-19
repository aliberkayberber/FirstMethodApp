using System;

namespace FirstMethodApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SingSong(); // 
            System.Console.WriteLine("2 ye bölümünden kalan: " + RandomNumber());
            System.Console.WriteLine("Çarpma işleminin sonucu: " + MultiplicationNumber(5,9));
            Greeting("Berkay","Berber");
        }

        static void SingSong() 
        {
            System.Console.WriteLine("Heyecandan her gece hayalini \nUnutursam ağlama unut beni");
        }
        static int RandomNumber() 
        {
            Random rnd = new Random(); 
            int number = rnd.Next(1,100); // random sayi üretiyoruz
            System.Console.WriteLine("Random sayi: " + number);
            return (number % 2); // ikiye bölümünü cevap olarak döndürüyoruz
        }

        static int MultiplicationNumber(int x , int y)
        {
            return (x*y);
        }

        static void Greeting(string name, string surname) 
        {
            System.Console.WriteLine($"Hoş Geldiniz {name} {surname}");
        }
    }

}
