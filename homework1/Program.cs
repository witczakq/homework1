using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                {
                    Console.WriteLine("Witaj. Jak masz na imię?");
                    var name = (Console.ReadLine());

                    Console.WriteLine("Podaj teraz dzień urodzin:");
                    var day = int.Parse(Console.ReadLine());

                    Console.WriteLine("Miesiąc:");
                    var month = int.Parse(Console.ReadLine());

                    Console.WriteLine("Rok:");
                    var year = int.Parse(Console.ReadLine());

                    Console.WriteLine("Podaj proszę miejsce urodzenia:");
                    var born = Console.ReadLine();

                    Console.WriteLine("Dziękuję za podanie informacji.");
                    var rokurodzin = new DateTime(year, month, day);
                    var century = AgeCalculate(rokurodzin);

                    Console.WriteLine($"Podsumowując:\nNazywas się {name}, masz ukończone {century} lat oraz Twoje miejsce urodzenia to: {born}.");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("\n \n Podałeś niepoprawne informacje ");
                throw;
            }
            finally
            {
                Console.ReadKey();
            }
        }
        private static int AgeCalculate(DateTime BirthDate)
        {
            var currentDate = DateTime.Now;
            var age = currentDate.Year - BirthDate.Year;
            if (currentDate.DayOfYear < BirthDate.DayOfYear)
                age--;
            return age;
        }
    }
}


