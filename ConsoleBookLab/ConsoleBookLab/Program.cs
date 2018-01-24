using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookLabDll;

namespace ConsoleBookLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            BookLib lib = new BookLib();

            menu.List = lib;

            do
            {
                menu.printTitle();
                string opt = menu.chooseOption();
                menu.processWithOption(opt);

            } while (!menu.Existed);
            
            Console.ReadKey(); 
            
        }
    }
}
