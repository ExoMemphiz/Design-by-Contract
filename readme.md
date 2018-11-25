# Assignment #7 - Design by Contract
  
Made by Chris Rosendorf  
  
  
### Project
  
The project is written in C#, and includes 2 main files, the Account.cs, and Program.cs  
  
  
#### Account.cs  
  
Account.cs is the implementation of an account, where the Design by Contract code is located.  
By using Contract.Requires the application requires a given input to the function to be valid with all specified requirements.  
  
An example being the Deposit function only requiring the deposited amount to be greater than 0, otherwise a custom error is thrown.  
The error ArgumentOutOfRangeException was chosen as it suits the required exception, although there might exist one that fits better.  
  
  
Additionally, the Withdraw function has 2 requirements  
1) The amount must be > 0, and  
2) The amount must be equal to or less than the balance from which is trying to be withdrawn.  
  
If either of those conditions are broken, the custom error will be thrown.
  
  
#### Program.cs  
  
Contains some "tests" which run through the various ways you can use the functions in the Account class.  
  
Some of the tests will fail (marked with "Fail" in the function name), as the requirements are not met.  
The others will pass, as they do meet the requirements that is described in the function being used.
