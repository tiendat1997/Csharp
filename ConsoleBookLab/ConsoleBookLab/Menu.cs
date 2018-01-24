using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookLabDll;

namespace ConsoleBookLab
{
    class Menu
    {
        private BookLib _list;
        private bool existed;
        public BookLib List { get => _list; set => _list = value; }
        public bool Existed { get => existed; set => existed = value; }

        public Menu()
        {
            existed = false; 
        }
        public bool addNewBook()
        {            
            Console.WriteLine("Add New Book");
            Console.Write("Id: ");
            String id = Console.ReadLine();
            Console.Write("Name: ");
            String name = Console.ReadLine();
            Console.Write("Owner: ");
            String owner = Console.ReadLine();
            Console.Write("Publisher: ");
            String publisher = Console.ReadLine();

            Book book = new Book(id, name, owner, publisher);

            

            return List.addBook(book);
        }
        public bool removeBook()
        {
            Console.WriteLine("Remove Book ");
            Console.Write("Id: ");
            string id = Console.ReadLine();

            return List.removeBook(id);
        }
        public void findBook()
        {
            Console.WriteLine("Find Book by Name (approximate)");
            Console.Write("Enter Name: ");
            String value = Console.ReadLine();

            List<Book> books = List.findBook(value);
            if (books.Count == 0)
            {
                Console.WriteLine("No books founded");
                return; 
            }

            foreach (var book in books)
            {
                Console.WriteLine(book.ToString());
            }


        }
        public void listBook()
        {
            Console.WriteLine("Print List Book");
            List.printListBook();
        }
        // True - continue ; else
        public bool continueOrNot(string msg)
        {
            Console.Write(msg);
            string opt = Console.ReadLine();

            bool cont = (opt.Equals("y"));           

            return cont; 
        }
        public void processWithOption(string opt)
        {
            switch (opt)
            {
                case "1":                   
                    do
                    {
                        bool result = addNewBook();
                        if (result)
                        {
                            Console.WriteLine("Add Successfully");
                        }
                        else
                        {
                            Console.WriteLine("Id has already existed");
                        }

                    } while (continueOrNot("Continue or Not (y/n): "));
                    
                    break;
                case "2":
                    do
                    {
                        bool result = removeBook();
                        if (result)
                        {
                            Console.WriteLine("Remove Successfully");
                        }
                        else
                        {
                            Console.WriteLine("Book is not existed");
                        }
                    } while (continueOrNot("Continue or Not (y/n): "));
                    break;
                case "3":
                    do
                    {
                        findBook();
                    } while (continueOrNot("Continue or Not (y/n): "));
                    break;
                case "4":

                    listBook();
                    break;
                case "5":
                    if(continueOrNot("Do you want to exit (y/n): "))
                    {
                        existed = true;
                        Console.WriteLine("Exit Propram");
                    }                                      
                    break;
                default:
                    Console.WriteLine("No option found - try again !");
                    break;
            }

        }


        public string chooseOption()
        {
            Console.Write("Input Your choose: ");
            string opt = Console.ReadLine();

            return opt;             
        }
        public void printTitle()
        {
            Console.WriteLine("-- Welcome to Book Management --");
            Console.WriteLine("1. Add a Book");
            Console.WriteLine("2. Remove a Book");
            Console.WriteLine("3. Find Book base Book Name");
            Console.WriteLine("4. List Book");
            Console.WriteLine("5. Exit");
        }
        
    }
}
