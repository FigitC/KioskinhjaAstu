using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KioskinHjaAstu
{
    public class Product
    {
        //Constructors
        public Product(string name, double price, bool active)
        {
            this.name = name;
            this.price = price;
            this.active = active;

        }
        public Product(bool ccanBeBoughtOnCredit)
        {
            this.canBeBoughtOnCredit = canBeBoughtOnCredit;
        }

        //Class fields
        public int productID
        {
            get { return _productID; }
            set {  if(value >= 1) { _productID = value; } }
        }
        private int _productID;
        public string name
        {
            get { return _name; }
            set { if(value != null) { _name = value; } }
        }
        private string _name;
        public double price
        {
            get { return _price; }
            set { if(value != 0) { _price = value; } }
        }
        private double _price;
        public bool active { get; private set; }
        public bool canBeBoughtOnCredit { get; private set; }

        // Methods
        public override string ToString()
        {
            return "Product: #" + productID.ToString() + " - " + name.ToString() + ", " + price.ToString() + "kr.";
        }
    }
}
