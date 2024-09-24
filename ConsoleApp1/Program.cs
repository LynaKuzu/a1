using System.Runtime.InteropServices;
using System.Security.Cryptography;

Console.WriteLine("As you wake up to the deck of cards in front of you, you meet gazes with the man across from you");
Console.ReadLine();
Console.WriteLine("What game do you wish to play?\n1) Go Fish\n2) BlackJack");
Random ran = new Random();
string choice = Console.ReadLine();

if (choice == "1")
{
    Console.WriteLine("what number do you guess?\n pick from 1 to 13");
    string num3 = Console.ReadLine();
    int num2 = int.Parse(num3);
    int num = ran.Next(1, 13);
    Console.WriteLine($"you picked {num2} I had {num}");
    if (num == num2)
    {
        Console.WriteLine("Correct!");
    }
    else
    {
        Console.WriteLine("Wrong!");
    }
}
else
{
    int num = ran.Next(2, 21);
    Console.WriteLine($"you have a value of {num} what will you do?\n1) Hit\n2) Stand");
    string num3 = Console.ReadLine();
    if (num3 == "1")
    {
        int num4 = ran.Next(1, 13);
        num = num + num4;
        Console.WriteLine($"you drew a {num4} you now have {num}");
    }
    int num2 = ran.Next(2, 21);
    Console.WriteLine($"you have {num}\n you opponent has {num2}");
    if (num == num2)
    {
        Console.WriteLine("Draw");
    }
    else if (num > 21)
    {
        Console.WriteLine("Bust!");
    }
    else if (num > num2)
    {
        Console.WriteLine("You Win!");
    }
    else
    {
        Console.WriteLine("You Lose!");
    }
}
Console.ReadLine();
