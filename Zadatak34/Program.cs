using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak34
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IRentable> List = new List<IRentable>();
            List.Add(new Video("3 musketira"));
            List.Add(new Book("Crvenkapica"));
            List.Add(new HotItem(new Video("Sam u kuci 2")));
            List.Add(new HotItem(new Book("Pale sam na svijetu")));


            RentingConsolePrinter printer = new RentingConsolePrinter();
            printer.DisplayItems(List);
        }
    }
}
