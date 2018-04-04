using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simba.Models
{
    public class AnimalList
    {
        public List<BankAccount> bankAccounts = new List<BankAccount>
            {
                new BankAccount("Simba", 2000, "Lion", true, "Good"),
                new BankAccount("Scar", 4000, "Lion", false, "Bad"),
                new BankAccount("Rafiki", 1000, "Mandrill", false, "Good"),
                new BankAccount("Zazu", 1000, "Bird", false, "Good"),
                new BankAccount("Banzai", 0, "Hyena", false, "Bad"),
            };
    }
}
