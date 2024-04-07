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
            Console.WriteLine("Welcome ! Please enter 'c' to use Currency Converter or anything else to use the Temperature Converter.");
            
            string operation = Console.ReadLine();
            
            if(operation == "c")
            {
                Console.WriteLine("You have selected the Currency Converter Operation!");
                Console.WriteLine("Please enter 'a' to Convert from Pounds or anything else to convert from Euros.");
                
                string decdision = Console.ReadLine();

                if(decdision == "a")
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
        }    
    }
}
