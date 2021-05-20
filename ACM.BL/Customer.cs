using System;

namespace ACM.BL
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int CustomerId { get; private set; }

        public string FullName
        {
            get
            {
                string fullName = LastName; // if no first name, full name is only last name without commas
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(LastName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }

        public void PrintName()
        {
            Console.WriteLine(FullName);
        }
    }
}
