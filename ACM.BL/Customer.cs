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
            CustomerCount++;
        }

        public static int CustomerCount = 0;


        public bool Validate()
        {
            bool isValid = false;
            bool lNameEmpty = string.IsNullOrWhiteSpace(LastName);
            bool emailEmpty = string.IsNullOrWhiteSpace(Email);
            bool emailContains = Email.Contains("@") && Email.Contains(".");
            bool emailValid = false;
            if (emailContains && !emailEmpty)
            {
                emailValid = true;
            }

            if (!lNameEmpty && emailValid)
            {
                isValid = true;
            }


            return isValid;
        }
    }
}
