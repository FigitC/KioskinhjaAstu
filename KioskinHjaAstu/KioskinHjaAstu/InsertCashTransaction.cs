using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KioskinHjaAstu
{
    public class InsertCashTransaction : Transaction
    {
        public InsertCashTransaction(User transactionUser, double amount)
        {
            transactionID = transactionCount++;
            this.transactionUser = transactionUser;
            this.amount = amount;
        }

        public override void Execute()
        {
            transactionUser.balance += amount;
        }

        public override string ToString()
        {
            return "InsertCashTransaction: " + amount.ToString() +
                   "\nMade by: " + transactionUser.ToString() +
                   "\nTimestamp: " + timeOfTransaction.ToString() +
                   "\nTransactionID: " + transactionID.ToString();
            
        }
    }
}
