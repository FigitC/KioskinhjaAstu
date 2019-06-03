using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KioskinHjaAstu
{
    public class SeasonalProduct : Product
    {
        //Constructor
        public SeasonalProduct(string name, double price, bool active, bool canBeBoughtOnCredit, DateTime seasonEndDate) : base(name, price, active, canBeBoughtOnCredit)
        {
            seasonStartDate = DateTime.Now;
            this.seasonEndDate = seasonEndDate;
        }

        //Class fields
        public DateTime seasonStartDate = new DateTime();
        public DateTime seasonEndDate = new DateTime();

        // Methods
        public override string ToString()
        {
            return "SeasonalProduct: #" + productID.ToString() + " - " + name.ToString() + ", " + price.ToString() + "kr. - " + "Expiration date: " + seasonEndDate.ToString();
        }
        private bool CheckIfSeasonalProdcutIsExpired(DateTime seasonStartDate, DateTime seasonEndDate)
        {

        }
    }
}
