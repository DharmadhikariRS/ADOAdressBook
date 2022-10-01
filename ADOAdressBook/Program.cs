namespace ADOAdressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to contact management program");
            AddressBookADO Book = new AddressBookADO();

            ShowOptions();

            void ShowOptions()
            {
                Console.Write("\n Select Option : 1.Display Contacts\n 2.Add contact\n");
                Console.WriteLine();
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Book.GetContactDetails();
                        ShowOptions();
                        break;
                    case 2:
                        Book.AddContact();
                        ShowOptions();
                        break;
                    default:
                        Console.WriteLine("Enter correct choice");
                        break;
                }

            }
        }
    }
}