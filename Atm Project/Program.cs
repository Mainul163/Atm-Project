﻿using System;

public class cardHolder
{
    string cardNum;
    int pin;
    string firstName;
    string lastName;
    double balance;

    public cardHolder(string cardNum, int pin, string firstName, string lastName, double balance)
    {


        this.cardNum = cardNum;
        this.pin = pin;
        this.firstName = firstName;
        this.lastName = lastName;
        this.balance = balance;

    }


    public string getCardNum()
    {
        return cardNum;

    }



    public int getPin()
    {
        return pin;
    }

    public string getFirstName()
    {
        return firstName;
    }
    public string getLastName()
    {
        return lastName;

    }
    public double getBalance()
    {
        return balance;
    }


    public void setPin(int newPin)
    {
        pin= newPin;
    }

    public void setNum(string newCardNUm)
    {
        cardNum=newCardNUm;
    }

    public void setFirstName(string newFirstName)
    {
        firstName=newFirstName;
    }
    
    public void setLastName(string newLastName) 
    { 
    
        lastName=newLastName;
    }

    public void setBalance (double newBalance) 
    { 
        balance=newBalance; 
    }


    public static void Main (string[] args)
    {
        
        void printOptions()
        {
            Console.WriteLine("Please choose from one of the following options.....");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4.  Exit");
            Console.ReadLine();
        }

        void deposit (cardHolder currentUser)
        {
            Console.WriteLine(" How much $$ would you like to deposit: ");
            double deposit= Double.Parse(Console.ReadLine());
            currentUser.setBalance(deposit);
            Console.WriteLine("Thank you for your $$. Your new balance is: " + currentUser.getBalance());
        }

        void withdraw(cardHolder currentUser)
        {
            Console.WriteLine("How much $$ would you like to withdraw: ");
            double withdrawal=Double.Parse(Console.ReadLine());

            if (currentUser.getBalance() > withdrawal)
            {
                Console.WriteLine("Insufficient balance :(");
            }
            else
            {
                currentUser.setBalance(currentUser.getBalance() - withdrawal);
                Console.WriteLine("you're good to go! THank You :)");
                Console.ReadLine();
            }
        }

         void balance (cardHolder currentUser)
        {
            Console.WriteLine("Current balance: " + currentUser.getBalance());
            Console.ReadLine();

        }

            List<cardHolder> cardHolders= new List<cardHolder>();
            cardHolders.Add(new cardHolder("123", 123, "john", "griffith", 150.31));
            cardHolders.Add(new cardHolder("1236488", 1244, "rkib", "th", 180.31));
            cardHolders.Add(new cardHolder("1236489", 125, "amir", "griffifth", 250.31));
            cardHolders.Add(new cardHolder("1236490", 126, "mainul", "riffith", 190.31));
            cardHolders.Add(new cardHolder("1236491", 127, "siam", "griffh", 159.31));

            //Prompt user
            Console.WriteLine("Welcome to SimpleAtm");
            Console.WriteLine("Please insert your debit card");
            string debitCardNum = "";
            cardHolder currentUser;
            
         while (true)
        {
            try
            {
                debitCardNum= Console.ReadLine();
                currentUser=cardHolders.FirstOrDefault(a=>a.cardNum==debitCardNum);
                if (currentUser != null)
                {
                    break;
                }
                else {

                    Console.WriteLine(" card not recognized . please try again");
                  
                    }
            }
            catch
            {
                Console.WriteLine(" card not recognized . please try again");
               
            }
        }
        Console.WriteLine("Please enter your pin");
        int userPin = 0;

        while (true)
        {
            try
            {
                userPin = int.Parse( Console.ReadLine());
                
                if (currentUser.getPin() == userPin)
                {
                    break;
                }
                else
                {

                    Console.WriteLine(" Incorrect pin . please try again");
                    Console.ReadLine();
                }
            }
            catch
            {
                Console.WriteLine(" Incorrect pin . please try again");
                Console.ReadLine();
            }
        }

        Console.WriteLine("Welcome " + currentUser.getFirstName() + " :) ");
        int option = 0;
        do
        {
            printOptions();
            try
            {
                option = int.Parse( Console.ReadLine());
            }
            catch { }
            if (option == 1) { deposit(currentUser); }
            else if (option == 2) { withdraw(currentUser); }
            else if (option == 3) { balance(currentUser); }
            else if (option == 4) { break; }

            else
            {
                option = 0;
            }
        }
        while (option != 4);
        Console.WriteLine("Thank You! Have a nice day :)");

        
    }

}

