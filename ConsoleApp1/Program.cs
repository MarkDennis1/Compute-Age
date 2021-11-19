using System;

namespace act1
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean tryAgain = false;

            while (tryAgain == false)
            {
                Console.WriteLine("************INPUT************");
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Section: ");
                string section = Console.ReadLine();

                Console.Write("Birthday: ");
                string birthDate = Console.ReadLine();
                string[] arrBirthDate = birthDate.Split(',');

                Console.Write("Current Year: ");
                string currentYear = Console.ReadLine();
                Console.WriteLine();

                try
                {
                    int age = int.Parse(currentYear) - int.Parse(arrBirthDate[1]);

                    Console.WriteLine("************OUTPUT************");
                    Console.WriteLine("Name : " + name);
                    Console.WriteLine("Section: " + section);
                    Console.WriteLine("Birthday: " + birthDate);
                    Console.WriteLine("Current Year: " + currentYear);
                    Console.WriteLine("Age: " + age);
                    Console.WriteLine();
                    Console.WriteLine("************Try Again************");
                    Console.Write("Would you like to try again? y/n: ");
                    string retry = Console.ReadLine();

                    if (retry.ToUpper() == "Y" || retry.ToUpper() == "YES")
                    {
                        Console.Clear();
                        tryAgain = false;
                    }
                    else
                    {
                        tryAgain = true;
                    }

                }
                catch (Exception)
                {

                    Console.WriteLine("************Try Again************");
                    Console.WriteLine("Invalid date format!");
                    Console.Write("Would you like to try again? y/n: ");
                    string retry = Console.ReadLine();

                    if (retry.ToUpper() == "Y" || retry.ToUpper() == "YES")
                    {
                        Console.Clear();
                        tryAgain = false;
                    }
                    else {
                        tryAgain = true;
                    }
                }
            }
        }
    }
}