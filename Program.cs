using BankEncapsulation;

BankAccount myAccount = new BankAccount();



Console.WriteLine("How much do you want to deposit?");
double depositAmount = double.Parse(Console.ReadLine());


myAccount.Deposit(depositAmount);


Console.WriteLine($"My new balance amount is {myAccount.GetBalance()}");