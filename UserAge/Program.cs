using System;

namespace UserAge
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja vanust;
            //programm arvutab kasutaja sünniaastat;
            //programm kuvab sünniaastat konsoolis;
            //"Oled sündinud {YearOfBirth}"

            Console.WriteLine("Kui vana te olete?");
            int UserAge = Convert.ToInt32(Console.ReadLine());
            int YearOfBirth = 2022 - UserAge;
            Console.WriteLine("Olete sündinud " + YearOfBirth + " aastal.");
        }
    }
}
