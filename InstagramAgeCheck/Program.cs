using System;

namespace InstagramAgeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja vanust;
            //programm kontrollib kas kasutaja on vanem kui 13 aasta või 13 aastat vanem;
            //kui kasutaja on 13 aastat või vanem siis ta võib Instagrammi kasutada;
            //kui kasutaja on noorem kui 13 siis ta on liiga noor.

            Console.WriteLine("Palun sisesta oma vanus:");
            int userAge = Convert.ToInt32(Console.ReadLine());

            if (userAge > 13)
            {
                Console.WriteLine("Oled piisavalt vana, et kontot luua.");
            }
            else if (userAge < 13 )
            {
                Console.WriteLine("Oled liiga noor, et Instagrammi luua.");
            }    
            else
            {
                Console.WriteLine("Oled piisavalt vana, et kontot luua.");

            }
            Console.WriteLine("Kena päeva!");
        }
    }
}
