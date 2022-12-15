using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystemSolution
{
    internal class AddressBook
    {
        ContackBook contackBook = new ContackBook();
        public void AddcontackBookIncontackBookBook()
        {
            Console.Write("Enter  FirstName: ");
            contackBook.firstName = Console.ReadLine();
            Console.Write("Enter  LastName: ");
            contackBook.lastName = Console.ReadLine();
            Console.Write("Enter  Address: ");
            contackBook.address = Console.ReadLine();
            Console.Write("Enter  City: ");
            contackBook.city = Console.ReadLine();
            Console.Write("Enter  State: ");
            contackBook.state = Console.ReadLine();
            Console.Write("Enter  Zip: ");
            contackBook.zipCode = Console.ReadLine();
            Console.Write("Enter  PhoneNumber: ");
            contackBook.phoneNumber = Console.ReadLine();
            Console.Write("Enter  Email: ");
            contackBook.email = Console.ReadLine();
        }
        public void DisplayContactBook()
        {
            Console.WriteLine("Contact Derails : \n" + "First Name : " + contackBook.firstName + "\n" + "Last Name : " + contackBook.lastName
                                    + "\n" + "Address is : " + contackBook.address + "\n" + "City is : " + contackBook.city + "\n" + "State is : " + contackBook.state
                                    + "\n" + "Zip is : " + contackBook.zipCode + "\n" + "Phone Number is :" + contackBook.phoneNumber + "\n" + "Email is : " + contackBook.email);
        }
    }
}
