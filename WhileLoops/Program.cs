Random rnd = new Random();
int cpuRandom;

while(true)
{
    cpuRandom = rnd.Next(1, 4);
    Console.WriteLine("Make a guess. Enter a number 1-3");

    int userNum = Int32.Parse(Console.ReadLine());

    if (userNum == cpuRandom)
    {
        Console.WriteLine("Congratulations, you won!");
        break;
    }
    else
    {
        Console.WriteLine("Try again");
    }
}

Console.WriteLine("Bye bye!");