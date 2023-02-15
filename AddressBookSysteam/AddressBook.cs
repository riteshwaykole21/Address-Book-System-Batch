using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSysteam
{
    public class AddressBook
    {
        Contact contact = new Contact();
        public void CreateContact()
        {
            contact.FirstName = Console.ReadLine();
            contact.LastName = Console.ReadLine();
            contact.Adderss = Console.ReadLine();
            contact.Email = Console.ReadLine();
            contact.phoneNumber = Console.ReadLine();
            contact.city = Console.ReadLine();
            contact.state = Console.ReadLine();
            contact.Zip = Convert.ToInt32(Console.ReadLine());
        }
        public void Display()
        {
            Console.WriteLine("Contact Details" + "\n FirstName"+contact.FirstName+"\n LastName"+contact.LastName+"\n Address " +contact.Adderss+"\n Email " +contact.Email+"\n phone number " +contact.phoneNumber+"\n city " +contact.city+"\n state" +contact.state+"\n Zip "+contact.Zip);
        }
    }
}
