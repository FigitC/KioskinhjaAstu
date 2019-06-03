using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace KioskinHjaAstu
{
    public class User : IComparable
    {
        static int userCount = 0;

        int userID;
        string firstName;
        string lastName;
        string userName;
        string email;
        public decimal balance = 0;



        public User(string firstName, string lastName, string userName, string email, decimal balance)
        {
            try
            {
                if (ValidName(firstName))
                {
                    this.firstName = firstName;
                }

                if (ValidName(lastName))
                {
                    this.lastName = lastName;
                }

                if (ValidUserName(userName))
                {
                    this.userName = userName;
                }

                if (ValidEmail(email))
                {
                    this.email = email;
                }

                this.balance = balance;

                userID = userCount++;
            }
            catch (Exception e)
            {
                throw e;
            }

            
        }

        private bool ValidName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Invalid first or lastname");
            }
            else
            {
                return true;
            }
        }

        private bool ValidUserName(string userName)
        {
            Regex regexItem = new Regex(@"^[a-z0-9_]*$");

            if (regexItem.IsMatch(userName))
            {
                return true;
            }
            else
            {
                throw new ArgumentException("Invalid username");
            }
        }

        private bool ValidEmail(string email)
        {
            Regex regexItem = new Regex(@"^[a-zA-Z0-9.-_]+@[a-zA-Z0-9.-]+$");
            
            if (regexItem.IsMatch(email))
            {
                return true;
            }
            else
            {
                throw new Exception("Invalid email address");
            }


        }
        
        public override string ToString()
        {
            return firstName + " " + lastName + " " + email;
        }

        public override int GetHashCode()
        {
            return userID;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
                return false;
            else
            {
                User varUser = obj as User;

                if (this.userID == varUser.userID)
                    return true;
                else
                    return false;
            }
        }

        public int CompareTo(object obj)
        {
            if(obj == null)
            {
                return 1;
            }

            User varUser = obj as User;

            if(varUser != null)
            {
                return this.userID.CompareTo(varUser.userID);
            }
            else
            {
                throw new ArgumentException("Object is not a User");
            }
        }
    }
}
