using System.Globalization;

CultureInfo cultureInfo = new CultureInfo("en-US");
Console.Write("The horse count: ");
int horseCount = int.Parse(Console.ReadLine());
double[] horses = new double[horseCount];
//int.TryParse(horseCountString, out int count);

//Console.Write("Set the race date (dd/MM/yyyy HH:mm): ");
//string dateTimeString = Console.ReadLine();
//if (!DateTime.TryParseExact(dateTimeString, "d/M/yyyy HH:mm", cultureInfo, DateTimeStyles.None, out DateTime raceDateTime))
//    raceDateTime = DateTime.Now;

for (int h = 0; h < horses.Length; h++)
{
    horses[h] = 1; //start location
    Console.WriteLine("-H" + (h + 1).ToString());
}

Console.WriteLine("\nPress any key to start.");
Console.ReadLine();
Console.Clear();

Random rnd = new Random();

bool race = true;

DateTime startRace = DateTime.Now;

do
{
    Console.Clear();

    for (int h = 0; h < horses.Length; h++)
    {
        horses[h] = horses[h] + rnd.NextDouble() * (6.0 - 1.0) + 1.0;
        if (horses[h] > 100)
            race = false;

        string myString = "";

        for (int k = 0; k < horses[h]; k++)
            myString = "-" + myString;

        myString = myString + "H" + (h + 1).ToString();

        Console.WriteLine(myString);

    }
    Thread.Sleep(500);
} while (race);

TimeSpan finishRace = DateTime.Now.Subtract(startRace);
double theBiggest = 0;
int winner = 0;

for (int h = 0; h < horses.Length; h++)
{
    if (horses[h] > theBiggest)
    {
        theBiggest = horses[h];
        winner = h;
    }
}
Console.WriteLine($"The race is over ==> The winner is H{(winner + 1).ToString()}({Math.Round(theBiggest, 2)}) The race time is: {finishRace}");

Console.ReadLine();

//static void RecursiveFunc(double[] arr, int process)
//{

//}