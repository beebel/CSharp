// Problem 11.	Bank Account Data
//
// A bank account has a holder name (first name, middle name and last name), available amount of money (balance), 
// bank name, IBAN, 3 credit card numbers associated with the account. Declare the variables needed to keep the 
// information for a single bank account using the appropriate data types and descriptive names.

using System;

    class BankAccountData
    {
        static void Main()
        {
            Console.Title = "11. Bank Account Data";
            string firstName = "Pesho";
            string middleName = "Peshev";
            string lastName = "Peshev";
            string holderName = firstName + " " + middleName + " " + lastName;
            decimal balance = 1345.55m;
            string bankName = "Central Bank";
            string countryCode = "BG";
            string checkDigits = "97";
            string bankcodeBIC = "WEST";
            string branchNumberBAE = "1234";
            string accountType = "56";
            string accountNumber = "SZ 000000";
            string BBAN = bankcodeBIC + " " + branchNumberBAE + accountType + accountNumber;
            string IBAN = countryCode + checkDigits + " " + BBAN;
            string creditCard1 = "1234 0343 2340 6543";
            string creditCard2 = "5675 9493 2343 2304";
            string creditCard3 = "8983 3402 0000 2133";
            Console.WriteLine("Holder name:     " + holderName);
            Console.WriteLine("Balance:         " + balance);
            Console.WriteLine("Bank name:       " + bankName);
            Console.WriteLine("IBAN:            " + IBAN);
            Console.WriteLine("Credit Card1:    " + creditCard1);
            Console.WriteLine("Credit Card2:    " + creditCard2);
            Console.WriteLine("Credit Card3:    " + creditCard3);
            Console.WriteLine();
        }
    }

