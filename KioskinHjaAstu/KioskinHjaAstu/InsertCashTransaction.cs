using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KioskinHjaAstu
{
    public class InsertCastTransaction : Transaction
    {
        public InsertCastTransaction(User transactionUser, decimal amount) : base(transactionUser, amount)
        {
            this.transactionUser = transactionUser;
            transactionID = transactionCount++;
        }

        public override void Execute()
        {
            transactionUser.balance += amount;
        }

        public override string ToString()
        {
            return "InsertCashTransaction: " + amount.ToString() +
                   "@\nMade by: " + transactionUser.ToString() +
                   "@\nTimestamp: " + timeOfTransaction.ToString() +
                   "@\nTransactionID: " + transactionID.ToString();
            
        }
    }
}
