    using System;

namespace örn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("adınızı giriniz");
            string name = Console.ReadLine();
            Console.WriteLine("soyadınızı giriniz");
            string surname = Console.ReadLine();
            Console.WriteLine(" hoş geldiniz " + name + " " + surname);
        }
    }
}
