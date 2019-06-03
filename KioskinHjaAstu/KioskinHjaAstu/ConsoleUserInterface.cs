using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KioskinHjaAstu
{
    public interface IConsoleUI
    {
        void DisplayUserNotFound(string username);
        void DisplayProductNotFound(string product);
        void DisplayUserInfo(User user);
        void DisplayTooManyArgumentsError(string command);
        void DisplayAdminCommandNotFoundMessage(string adminCommand);
        void DisplayUserBuysProduct(BuyTransaction transaction);
        void DisplayUserBuysProduct(int count, BuyTransaction transaction);
        void Close();
        void DisplayInsufficientCash(User user, Product product);
        void DisplayGeneralError(string errorString);
        void Start();
        event StregsystemEvent CommandEntered;
    }
    class ConsoleUserInterface :IConsoleUI
    {

        void DisplayUserNotFound(string username)
        {
            Console.WriteLine("User: " + username + " not found!");
        }

        void DisplayProductNotFound(string product)
        {
            Console.WriteLine("Product: " + product + " not found!");
        }

        void DisplayTooManyArgumentsError(string command)
        {

        }
    }
}
