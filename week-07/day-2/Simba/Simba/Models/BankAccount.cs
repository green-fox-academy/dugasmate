using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simba.Models
{
    public class BankAccount
    {
        public string name { get; set; }
        public int balance { get; set; }
        public string animalType { get; set; }
        public int id { get; set; }
        private static int m_Counter = 0;
        public bool isKing { get; set; }
        public string badOrGood { get; set; }

        public BankAccount(string name, int balance, string animalType, bool isKing, string badOrGood)
        {
            this.name = name;
            this.balance = balance;
            this.animalType = animalType;
            id = System.Threading.Interlocked.Increment(ref m_Counter);
            this.isKing = isKing;
            this.badOrGood = badOrGood;
           
        }
    }
}
