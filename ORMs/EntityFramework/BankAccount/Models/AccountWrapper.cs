using System;
using System.Collections.Generic;

namespace BankAccount.Models
{
    public class AccountWrapper
    {
        public Register User { get; set; }
        public List<Transaction> Transactions { get; set; }
        public Transaction FormTransaction { get; set; }
    }
}