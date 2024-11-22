namespace taskTwo

{
    internal class Program
    {
        static void DisplayMenu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Contact Management System");
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. Edit Contact");
            Console.WriteLine("3. Delete Contact");
            Console.WriteLine("4. Show All Contacts");
            Console.WriteLine("5. Exit");
        }
        static void Main(string[] args)
        {
            Content contactManager = new Content();

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                DisplayMenu();
                Console.Write("Select an option (1 to 5): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter first name: ");
                        string firstName = Console.ReadLine();
                        Console.Write("Enter last name: ");
                        string lastName = Console.ReadLine();
                        Console.Write("Enter phone number: ");
                        string phoneNumber = Console.ReadLine();
                        contactManager.AddContacts(firstName, lastName, phoneNumber);
                        break;

                    case "2":
                        Console.Write("Enter the phone number of the contact you want to edit: ");
                        string editPhone = Console.ReadLine();
                        contactManager.EditContacts(editPhone);
                        break;

                    case "3":
                        Console.Write("Enter the phone number of the contact you want to delete: ");
                        string deletePhone = Console.ReadLine();
                        contactManager.DeleteContact(deletePhone);
                        break;

                    case "4":
                        contactManager.DisplayAllContacts();
                        break;

                    case "5":
                        Console.WriteLine("Exiting the program...");
                        return;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}
