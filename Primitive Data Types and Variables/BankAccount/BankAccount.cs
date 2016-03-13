using System;

    class BankAccount
    {
    static void Main(string[] args)
    {
        string firstName = "Petar";
        string middleName = "Ivanov";
        string lastName = "Petrov";
        long balance = 849303024;
        string bank = "DSK";
        string IBAN = "BG3495069123439043";
        string BIC = "DSK1234";
        ulong creditcardNumber1 = 4658493023123456;
        ulong creditcardNumber2 = 5559996342145600;
        ulong creditcardNumber3 = 1134567721113456;

        Console.WriteLine("Customer Name: {0} {1} {2}\n Account Balance: {3}\n Bank Name: {4}\n IBAN: {5} BIC: {6}\n Card1: {7}\n Card2: {8}\n Card3: {9}", firstName,middleName,lastName,balance,bank,IBAN,BIC,creditcardNumber1,creditcardNumber2,creditcardNumber3);
        }
    }

