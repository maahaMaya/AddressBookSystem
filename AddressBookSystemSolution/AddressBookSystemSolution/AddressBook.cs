using System;

namespace AddressBookSystemSolution
{
    internal class AddressBook
    {
        //UC5
        List<ContackBook> listOfContactBook = new List<ContackBook>();
        //UC6
        Dictionary<string, List<ContackBook>> multipleListOfContactBook = new Dictionary<string, List<ContackBook>>();
        //UC2
        public void AddcontackBookIncontackBookBook()
        {
            ContackBook contackBook = new ContackBook();
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
            listOfContactBook.Add(contackBook);
        }
        //UC3
        public void EditContactBook()
        {
            Console.Write("Enter first name or last name to serach and edit : ");
            string inputSearchAndEditUsingName = Console.ReadLine();
            foreach (var data in multipleListOfContactBook)
                foreach (var contackBookData in data.Value)
                {
                    if ((contackBookData.firstName.Equals(inputSearchAndEditUsingName)) || (contackBookData.lastName.Equals(inputSearchAndEditUsingName)))
                    {
                        Console.WriteLine("1.FirstName 2.LastName 3.Address 4.City 5.State 6.Zip 7.PhoneNumber 8.Email : ");
                        int option = Convert.ToInt32(Console.ReadLine());
                        switch (option)
                        {
                            case 1:
                                Console.Write("Enter first name : ");
                                contackBookData.firstName = Console.ReadLine();
                                break;
                            case 2:
                                Console.Write("Enter last name : ");
                                contackBookData.lastName = Console.ReadLine();
                                break;
                            case 3:
                                Console.Write("Enter address : ");
                                contackBookData.address = Console.ReadLine();
                                break;
                            case 4:
                                Console.Write("Enter city : ");
                                contackBookData.city = Console.ReadLine();
                                break;
                            case 5:
                                Console.Write("Enter state : ");
                                contackBookData.state = Console.ReadLine();
                                break;
                            case 6:
                                Console.Write("Enter zip code : ");
                                contackBookData.zipCode = Console.ReadLine();
                                break;
                            case 7:
                                Console.Write("Enter first name");
                                contackBookData.phoneNumber = Console.ReadLine();
                                break;
                            case 8:
                                contackBookData.email = Console.ReadLine();
                                break;
                        }
                    }
                }  
        }

        //UC4
        public void DeleteContactBook()
        {
            Console.Write("Enter first name or last name to serach and delete : ");
            string inputSearchAndDeleteUsingName = Console.ReadLine();
            foreach (var data in multipleListOfContactBook)
                foreach (var contackBookData in data.Value)
                    if ((contackBookData.firstName.Equals(inputSearchAndDeleteUsingName)) || (contackBookData.lastName.Equals(inputSearchAndDeleteUsingName)))
                    {
                        //multipleListOfContactBook.Re (data.Key, out contackBookData);
                        //multipleListOfContactBook.Remove(data.Key);
                        break;
                    }      
        }
        //UC6
        public void MultipeContactAdd()
        {
            Console.Write("Enter the key for the list of contact : ");
            string contactBookKey = Console.ReadLine();
            multipleListOfContactBook.Add(contactBookKey, listOfContactBook);
            listOfContactBook = new List<ContackBook>();
        }
        public void DisplayContactBookForList()
        {
            foreach (var contackBookData in listOfContactBook)
                Console.WriteLine("Contact Derails : \n" + "First Name : " + contackBookData.firstName + "\n" + "Last Name : " + contackBookData.lastName
                                    + "\n" + "Address is : " + contackBookData.address + "\n" + "City is : " + contackBookData.city + "\n" + "State is : " + contackBookData.state
                                    + "\n" + "Zip is : " + contackBookData.zipCode + "\n" + "Phone Number is :" + contackBookData.phoneNumber + "\n" + "Email is : " + contackBookData.email);
        }
        public void DisplayContactBookForDictonary()
        {
            foreach(var data in multipleListOfContactBook)
            {
                Console.WriteLine("Contact book name is : " +data.Key);
                foreach (var contackBookData in data.Value)
                    Console.WriteLine("Contact Derails : \n" + "First Name : " + contackBookData.firstName + "\n" + "Last Name : " + contackBookData.lastName
                                        + "\n" + "Address is : " + contackBookData.address + "\n" + "City is : " + contackBookData.city + "\n" + "State is : " + contackBookData.state
                                        + "\n" + "Zip is : " + contackBookData.zipCode + "\n" + "Phone Number is :" + contackBookData.phoneNumber + "\n" + "Email is : " + contackBookData.email);
            }
        }
    }
}
