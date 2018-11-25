using System;
using c_;

namespace c_ {
    
    class Program {
        
        static void Main(string[] args) {
            DepositPassTest();
            DepositFailTest();
            WithdrawPassTest();
            WithdrawFailTest();
        }

        static void DepositPassTest() {
            double startingBalance = 100;
            double depositAmount = 50;
            Account acc = new Account(startingBalance);
            acc.Deposit(depositAmount);
            Console.WriteLine("I could deposit " + depositAmount + ", so now I should have " + (startingBalance + depositAmount) + ", test: " + acc.GetBalance());
        }

        static void DepositFailTest() {
            double startingBalance = 100;
            double depositAmount = 0;
            Account acc = new Account(startingBalance);
            acc.Deposit(depositAmount);
            Console.WriteLine("I could not deposit " + depositAmount + ", because the depositAmount conflicted with the Contract Requirment");
        }

        static void WithdrawPassTest() {
            double startingBalance = 100;
            double withdrawAmount = 80;
            Account acc = new Account(startingBalance);
            acc.Withdraw(withdrawAmount);
            Console.WriteLine("I could withdraw " + withdrawAmount + ", so now I should have " + (startingBalance + withdrawAmount) + ", test: " + acc.GetBalance());
        }
        
        static void WithdrawFailTest() {
            double startingBalance = 100;
            double withdrawAmount = 800;
            Account acc = new Account(startingBalance);
            acc.Withdraw(withdrawAmount);
            Console.WriteLine("I could not withdraw " + withdrawAmount + ", because the withdrawAmount conflicted with the Contract Requirment");
        }

    }
    
}
