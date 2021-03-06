﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KioskinHjaAstu
{
    public abstract class Transaction 
    {
        public static int transactionCount = 0;
        public int transactionID;
        public User transactionUser;
        public DateTime timeOfTransaction;
        public double amount;

        public abstract void Execute();
        public abstract override string ToString();
    }
}
