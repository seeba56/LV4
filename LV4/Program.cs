using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV4
{
    class Program
    {
        static void Main(string[] args)
        {
            Dataset data = new Dataset("file.csv");
            Analyzer3rdParty analyzer = new Analyzer3rdParty();
            Adapter adapter = new Adapter(analyzer);
            double[] colresult = adapter.CalculateAveragePerColumn(data);
            Console.WriteLine("Prosjek po stupcima: ");
            foreach(double colres in colresult)
            {
                Console.WriteLine(colres);
            }

            Console.WriteLine("Prosjek po redovima: ");
            double[] rowresult = adapter.CalculateAveragePerRow(data);
            foreach (double rowres in rowresult)
            {
                Console.WriteLine(rowres);
            }
        }
    }
}
