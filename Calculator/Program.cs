
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Calculator

{

    internal class Program

    {
       

        static void Main(string[] args)

        {
            try
            {
               
                Console.WriteLine("Wpisz jak masz na imię.");
                var name = Console.ReadLine();
                Console.WriteLine("\nWpisz w jakim mieście się urodziłeś.");
                var placeOfBirth = Console.ReadLine();
                Console.WriteLine("\nWpisz swój rok urodzenia.");
                var yearOfBirth = GetYear();
                Console.WriteLine("\nWpisz miesiąc urodzenia.");
                var monthOfBirth = GetMonth();
                Console.WriteLine("\nWpisz dzień urodzenia.");
                var dayOfBirth = GetDay(yearOfBirth, monthOfBirth);
                var timenow = DateTime.Now;
                var dateOfBirth = new DateTime(yearOfBirth, monthOfBirth, dayOfBirth);
                var age = DateTime.Now.Year - dateOfBirth.Year;
                var days = DateTime.Now.Day - dateOfBirth.Day;
                //Console.WriteLine(timenow);

                var today = DateTime.Today;
                //Console.WriteLine(today);

                if (DateTime.Now.DayOfYear < dayOfBirth);
                                      
                dateOfBirth = dateOfBirth.AddYears(1);

                var totalDays = (today - dateOfBirth).Days;
                                var welcome = $"\nCześć {name} urodziłeś sie w mieście {placeOfBirth} i masz {age} lata, czyli {totalDays} dni.";
                Console.WriteLine(welcome);
             

             
            }
            catch (Exception ex)
            {
                //logowanie
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine();
            }
        }

        private static int GetDay(int yearOfBirth, int monthOfBirth)
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int day) || day <1 || day > DateTime.DaysInMonth(yearOfBirth, monthOfBirth) ) 
                {
                    Console.WriteLine("Miesiąc urodzenia jest błędny - sprawdź format daty DD, Spróbuj jeszcze raz");
                    continue;
                }
                return day;

            }
        }

        private static int GetMonth()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int month) || month >12 || month <1)
                {
                    Console.WriteLine("Miesiąc urodzenia jest błędny - sprawdź format daty MM, Spróbuj jeszcze raz");
                    continue;
                }
                return month;

            }
        }

        private static int GetYear()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int year) || year>DateTime.Now.Year)
                {
                    Console.WriteLine("Rok urodzenia jest błędny - sprawdź format daty YYYY, Spróbuj jeszcze raz");
                    continue;
                }
                return year;
         
            }
        }

             
    }

}