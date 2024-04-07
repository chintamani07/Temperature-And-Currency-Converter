using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Welcome to Currency Converter System ****");
            Console.WriteLine("Welcome ! Please enter 'c' to use Currency Converter or anything else to use the Temperature Converter.");
            
            string operation = Console.ReadLine();
            
            if(operation == "c")
            {
                Console.WriteLine("You have selected the Currency Converter Operation!");
                Console.WriteLine("Please enter 'a' to Convert Currency from Pounds or anything else to convert from Euros.");
                
                string decision = Console.ReadLine();

                if(decision == "a")
                {
                    Console.WriteLine("Please enter your amount in Pounds : ");
                    float pounds = float.Parse(Console.ReadLine());
                    float euros = pounds * 1.16f;
                    Console.WriteLine("The amount in Euros is : " + euros.ToString("0.00"));
                }
                else
                {
                    Console.WriteLine("Please enter your amount in Euros : ");
                    float euros = float.Parse(Console.ReadLine());
                    float pounds = euros / 1.16f;
                    Console.WriteLine("The amount in Pounds is : " + pounds.ToString("0.00"));
                }
            }
            else
            {
                Console.WriteLine("***** Welcome to Temperature Converter System ****");
                Console.WriteLine("You have selected the Temperature Converter Operation!");
                Console.WriteLine("Please enter 'a' to Convert Temperature from Celcius or anything else to convert from Euros.");

                string decision = Console.ReadLine();

                if (decision == "a")
                {
                    Console.WriteLine("Please enter value in Celcius : ");
                    float celcius = float.Parse(Console.ReadLine());
                    float farhenhite = (float)(celcius * 1.8 + 32f);
                    Console.WriteLine("The temperature in Farhenhite is : " + farhenhite);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Please enter value in Farhenhite : ");
                    float farhenhite = float.Parse(Console.ReadLine());
                    float celcius = (farhenhite - 32f) / 1.8f;
                    Console.WriteLine("The temperature in Celcius is : " + celcius);
                    Console.ReadKey();
                }
            }
        }    
    }
}
