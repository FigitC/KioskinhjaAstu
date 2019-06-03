using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KioskinHjaAstu
{
    public class BuyTransaction : Transaction
    {
        
        Product boughtProduct;
        decimal currentPrice;
        
        public BuyTransaction(User transactionUser, Product product)
        {
            transactionID = transactionCount++;
            this.transactionUser = transactionUser;
            boughtProduct = product;
            amount = boughtProduct.price;
        }

        public override void Execute()
        {
            if (transactionUser.balance < amount || !boughtProduct.canBeBoughtOnCredit)
            
                throw new Exception("InsufficientCredits by user: " + transactionUser.userID +
                                    "\n Can't afford product: " + boughtProduct.ToString());
            
            else
                transactionUser.balance -= amount;
        }

        public override string ToString()
        {
            return "Product being bought: " + boughtProduct.ToString() +
                   "\nPrice: " + boughtProduct.price +
                   "\nBuying user: " + transactionUser.userID.ToString() +
                   "\nTime of transaction: " + timeOfTransaction.ToString() +
                   "\nTransaction ID: " + transactionID.ToString();

        }
    }
}
