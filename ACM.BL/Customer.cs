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
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(Email))
            {
                isValid = false;
            }
            else if (!Email.Contains("@"))
            {
                isValid = false;
            }
            else if (!Email.Contains("."))
            {
                isValid = false;
            }



            //if (Email.Contains("@") == false) isValid = false;
            //if (Email.Contains(".") == false) isValid = false;

            return isValid;





            //bool lNameEmpty = string.IsNullOrWhiteSpace(LastName);
            //bool emailEmpty = string.IsNullOrWhiteSpace(Email);
            //bool emailContainsAt = Email.Contains("@");
            //bool emailContainsDot = Email.Contains(".");

            //if (emailContainsAt && emailContainsDot)
            //{
            //    if (emailEmpty && lNameEmpty)
            //    {
            //        return true;
            //    }
            //    else
            //    {
            //        return false;
            //    }
            //}
            //else
            //{
            //    return false;
        }

    }

}
