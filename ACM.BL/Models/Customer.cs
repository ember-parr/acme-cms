using System;
using System.Collections.Generic;
using ACM.BL.Models;
using Acme.Common;
using System.ComponentModel.DataAnnotations;
using System.Threading;

namespace ACM.BL
{
    public class Customer : EntityBase, ILoggable
    {
        public Customer() : this(0)
        {

        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
        }

        public List<Address> AddressList { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int CustomerId { get; private set; }
        public int CustomerType { get; set; }

        public string Log() => $"{CustomerId}: {FullName} Email: {Email} Status: {EntityState.ToString()}";

        public override string ToString() => FullName;

        /// <summary>
        /// Formats name based on available data
        /// </summary>
        public string FullName
        {
            get
            {
                string fullName = LastName; // if no first name, name displ only last name without commas
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


        /// <summary>
        /// Prints formated full name
        /// </summary>
        public void PrintName()
        {
            Console.WriteLine(FullName);
        }

        /// <summary>
        /// checks for existing last name, email & valid email characters
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            if (string.IsNullOrWhiteSpace(LastName))
            {
                return false;
            }
            else if (string.IsNullOrWhiteSpace(Email))
            {
                return false;
            }
            else if (Email.Contains("@") == false)
            {
                return false;
            }
            else if (Email.Contains(".") == false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
}
}
