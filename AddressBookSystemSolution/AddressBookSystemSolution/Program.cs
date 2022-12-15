using System;
namespace AddressBookSystemSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddressBook addressBook = new AddressBook();
            bool flag = true;
            while (flag)
            {
                Console.Write("Enter the option : 1.AddContact 2.DisplayContact 3.Edit 4.Delete AnyOtherOption-Exit : ");
                int option = Convert.ToInt16(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        addressBook.AddcontackBookIncontackBookBook();
                        break;
                    case 2:
                        addressBook.DisplayContactBook();
                        break;
                    case 3:
                        addressBook.EditContactBook();
                        break;
                    case 4:
                        addressBook.DeleteContactBook();
                        break;
                    default:
                        flag= false;
                        break;
                }
            }
        }
    }
}