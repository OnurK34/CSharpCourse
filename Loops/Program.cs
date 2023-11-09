//ForLoop();
//WhileLoop();
//DoWhileLoop();
//ForEachLoop();

if (IsPrimeNumber(7))
{
    Console.WriteLine("This is a prime number");
}
else
{
    Console.WriteLine("This is a not a prime number");
}

Console.ReadLine();
static bool IsPrimeNumber(int number)
{
    bool result = true;
    for (int i = 2; i< number -1; i++)
    {
        if (number % i == 0)
        {
            result = false;
            i = number;
        }
    }
    return result;
}
static void ForEachLoop()
{
    string[] students = new string[3] { "Onur", "Adem", "Enes" };

    foreach (var student in students)
    {
        Console.WriteLine(student);
    }
}
static void DoWhileLoop()
{
    int number = 10;
    do
    {
        Console.WriteLine(number);
        number--;

    } while (number >= 11);
}
static void WhileLoop()
{
    int number = 100;
    while (number >= 0)
    {
        Console.WriteLine(number);
        number--;
    }
    Console.WriteLine("Now number is {0}", number);
}

static void ForLoop()
{
    for (int i = 100; i >= 0; i = i - 2)
    {
        Console.WriteLine(i);
    }
    Console.WriteLine("Finished!");
}



