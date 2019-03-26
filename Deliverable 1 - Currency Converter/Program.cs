using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Deliverable_1___Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            List<double> values = new List<double>();
            while (counter < 3)
            {
                Console.WriteLine("Please type a value: ");
                double test = Convert.ToDouble(Console.ReadLine());
                //Console.WriteLine(test);
                values.Add(test);
                counter++;
            }      
            
            Console.WriteLine("The average is: {0}", values.Average());
            Console.WriteLine("The smallest value is: {0}", + values.Min());
            Console.WriteLine("The largest value is: {0}", values.Max());

            double total = values.Sum();          

            Console.WriteLine(total.ToString("C2"));
            Console.WriteLine(total.ToString("C2", new CultureInfo("sv-SE")));
            Console.WriteLine(total.ToString("C0", new CultureInfo("ja-JP")));
            Console.WriteLine(total.ToString("C2", new CultureInfo("th-TH")));

            //string yourValue = (total / 100m).ToString("C2");
            //Console.WriteLine(yourValue);

            Console.ReadLine();
             
        }
    }
}
