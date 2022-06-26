// See https://aka.ms/new-console-template for more information
int playerRandomNum;
int computerRandomNum;

Random random = new Random();

for (int i = 0; i < 10; i++)
{

Console.WriteLine("Press Enter To Roll The Dice...");
    Console.ReadKey();

    playerRandomNum = random.Next(1, 7);
    Console.WriteLine("You rolled a " + playerRandomNum);

    Console.WriteLine("...");
    System.Threading.Thread.Sleep(1000);

    computerRandomNum = random.Next(1, 7);
    Console.WriteLine("Computer AI rolled a " + computerRandomNum);
}

Console.ReadKey();
