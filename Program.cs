using System;
class Program
{
    static void Main()
    {
        string name = "";
        string email = "";
        string contact = "";
        int points = 0;
        int voucherUsed = 0;
        int choice;

        Console.WriteLine("-----LOYALTY CARD SYSTEM-----");
        Console.Write("Enter Name: ");
        name = Console.ReadLine();
        Console.Write("Enter Email: ");
        email = Console.ReadLine();
        Console.Write("Enter Contact Number: ");
        contact = Console.ReadLine();
        Console.Write("Enter Starting Points: ");
        points = Convert.ToInt32(Console.ReadLine());

        do
        {
            Console.WriteLine("\n----- MENU -----");
            Console.WriteLine("1. Edit Information");
            Console.WriteLine("2. View Total Points");
            Console.WriteLine("3. Redeem Points");
            Console.WriteLine("4. Enter Voucher Code");
            Console.WriteLine("5. Delete Account");
            Console.WriteLine("6. Exit");
            Console.Write("Choose: ");
            choice = Convert.ToInt32(Console.ReadLine());
  switch
