using System;

namespace Userdata
{
    class Program
    {
        static void Main(string[] args)
        {
            // programm küsib kasutaja sünniaastat;
            // programm arvutab kasutaja vanust;
            //programm kuvab kasutaja vanust konsoolis;

            Console.WriteLine("Palun sissta oma sünniaasta:");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());

            int UserAge = 2022 - yearOfBirth;

            //Console.WriteLine("Oled " + UserAge + " aastat vana.");

            //string interpolation
            Console.WriteLine($" Oled {UserAge} aastat vana");
        }
    }
}
