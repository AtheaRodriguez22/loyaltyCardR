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

            switch (choice)
            {
                case 1:
                    Console.WriteLine("\n--- Edit Information ---");
                    Console.Write("New Name: ");
                    name = Console.ReadLine();
                    Console.Write("New Email: ");
                    email = Console.ReadLine();
                    Console.Write("New Contact: ");
                    contact = Console.ReadLine();
                    Console.WriteLine("Information Updated!");
                    break;

                case 2:
                    Console.WriteLine("\n--- Account Summary ---");
                    Console.WriteLine("Name: " + name);
                    Console.WriteLine("Email: " + email);
                    Console.WriteLine("Contact: " + contact);
                    Console.WriteLine("Points: " + points);
                    break;

                case 3:
                    Console.WriteLine("\n--- Redeem Options ---");
                    Console.WriteLine("1. KFC - 100 pts");
                    Console.WriteLine("2. Jollibee - 120 pts");
                    Console.WriteLine("3. Wendy's - 150 pts");
                    Console.WriteLine("4. McDonald's - 130 pts");
                    Console.WriteLine("5. Flight Discount - 300 pts");
                    Console.Write("Choose reward: ");
                    int reward = Convert.ToInt32(Console.ReadLine());

                    if (reward < 1 || reward > 5)
                    {
                        Console.WriteLine("Invalid reward choice.");
                    }
                    else if (reward == 1 && points >= 100) { points -= 100; Console.WriteLine("Redeemed KFC reward!"); }
                    else if (reward == 2 && points >= 120) { points -= 120; Console.WriteLine("Redeemed Jollibee reward!"); }
                    else if (reward == 3 && points >= 150) { points -= 150; Console.WriteLine("Redeemed Wendy's reward!"); }
                    else if (reward == 4 && points >= 130) { points -= 130; Console.WriteLine("Redeemed McDonald's reward!"); }
                    else if (reward == 5 && points >= 300) { points -= 300; Console.WriteLine("Redeemed Flight Discount!"); }
                    else { Console.WriteLine("Not enough points!"); }
                    break;

                case 4:
                    Console.WriteLine("\n--- Voucher Code ---");
                    if (voucherUsed == 1)
                    {
                        Console.WriteLine("You already used a voucher code.");
                        break;
                    }
                    Console.Write("Enter voucher code: ");
                    string voucher = Console.ReadLine();
                    if (voucher == "DREAMFLight")
                    {
                        points += 30;
                        voucherUsed = 1;
                        Console.WriteLine("Voucher applied! 30 points added to your account.");
                        Console.WriteLine("Current Points: " + points);
                    }
                    else
                    {
                        Console.WriteLine("Invalid voucher code.");
                    }
                    break;

                case 5:
                    Console.WriteLine("\n--- Delete Account ---");
                    Console.Write("Are you sure you want to delete your account? (yes/no): ");
                    string confirm = Console.ReadLine();
                    if (confirm.ToLower() == "yes")
                    {
                        name = "";
                        email = "";
                        contact = "";
                        points = 0;
                        Console.WriteLine("Account deleted. All data has been cleared.");
                        choice = 6;
                    }
                    else
                    {
                        Console.WriteLine("Delete cancelled.");
                    }
                    break;

                case 6:
                    Console.WriteLine("Thank you for using the system!");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        } while (choice != 6);
    }
}
