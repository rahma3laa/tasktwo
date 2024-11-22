using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskTwo
{
    internal class User
    {
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public User(string firstname, string lastname,string phonenumber)
        {
            FirstName = firstname;
            LastName = lastname;
            PhoneNumber = phonenumber;

        }
        public void DisplayContact()
        {
            Console.WriteLine($"FirstName: {FirstName} , LastName: {LastName} , PhoneNumber: {PhoneNumber}");
        }
    }
}
