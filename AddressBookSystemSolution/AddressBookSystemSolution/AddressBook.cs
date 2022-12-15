using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Xml.Linq;

namespace AddressBookSystemSolution
{
    internal class AddressBook
    {
        ContackBook contackBook = new ContackBook();
        //UC2
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
        //UC3
        public void EditContactBook()
        {
            Console.Write("Enter name to serach and edit : ");
            string inputSearchAndEditUsingName = Console.ReadLine();
            if ((contackBook.firstName.Equals(inputSearchAndEditUsingName)) || (contackBook.lastName.Equals(inputSearchAndEditUsingName)))
            {
                Console.WriteLine("1.FirstName 2.LastName 3.Address 4.City 5.State 6.Zip 7.PhoneNumber 8.Email : ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.Write("Enter first name : ");
                        contackBook.firstName = Console.ReadLine();
                        break;
                    case 2:
                        Console.Write("Enter last name : ");
                        contackBook.lastName = Console.ReadLine();
                        break;
                    case 3:
                        Console.Write("Enter address : ");
                        contackBook.address = Console.ReadLine();
                        break;
                    case 4:
                        Console.Write("Enter city : ");
                        contackBook.city = Console.ReadLine();
                        break;
                    case 5:
                        Console.Write("Enter state : ");
                        contackBook.state = Console.ReadLine();
                        break;
                    case 6:
                        Console.Write("Enter zip code : ");
                        contackBook.zipCode = Console.ReadLine();
                        break;
                    case 7:
                        Console.Write("Enter first name");
                        contackBook.phoneNumber = Console.ReadLine();
                        break;
                    case 8:
                        contackBook.email = Console.ReadLine();
                        break;
                }
            }
        }
        public void DisplayContactBook()
        {
            Console.WriteLine("Contact Derails : \n" + "First Name : " + contackBook.firstName + "\n" + "Last Name : " + contackBook.lastName
                                    + "\n" + "Address is : " + contackBook.address + "\n" + "City is : " + contackBook.city + "\n" + "State is : " + contackBook.state
                                    + "\n" + "Zip is : " + contackBook.zipCode + "\n" + "Phone Number is :" + contackBook.phoneNumber + "\n" + "Email is : " + contackBook.email);
        }
    }
}
