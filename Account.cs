using System.Diagnostics.Contracts;
using System;

namespace c_ {

    class Account {

        private double balance;

        public Account(double balance = 0) {
            this.balance = balance;
        }

        public void Deposit(double amount) {
            Contract.Requires<ArgumentOutOfRangeException>(amount > 0, "Amount to deposit must be greater than 0");
            this.balance += amount;
        }

        public void Withdraw(double amount) {
            Contract.Requires<ArgumentOutOfRangeException>(amount <= this.balance, "Amount must be a number equal to, or less than the current balance");
            Contract.Requires<ArgumentOutOfRangeException>(amount > 0, "Amount to withdraw must be greater than 0");
            this.balance -= amount;
        }

        public double GetBalance() {
            return this.balance;
        }

    }

}
