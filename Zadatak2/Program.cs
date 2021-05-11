using System;

namespace Zadatak2
{
    class Program
    {
        static void Main(string[] args)
        {
            Window window1 = new Window();
            window1.aktivan = true;
            window1.boja = new Boja(255, 255, 255);
            window1.naslov = "window1";
            window1.oznaka = "A";

            Window window2 = new Window("window2");


            //Console.WriteLine(window1);
            //Console.WriteLine(window1.GetInfo());
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(window1.Draw());
        }
    }
}
