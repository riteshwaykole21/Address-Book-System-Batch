using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSysteam
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Systeam");
            AddressBook addressBook = new AddressBook();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter 1: Creating Contact \n 2:Editing Contact");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine();
                        addressBook.CreateContact();
                        addressBook.Display();
                        break;
                    case 2:
                        Console.WriteLine("Edit Contact");
                        addressBook.EditContact("Ritesh");
                        addressBook.Display();
                        break;
                    case 3:
                        flag = false;
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}