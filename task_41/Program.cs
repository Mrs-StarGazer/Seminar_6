Console.WriteLine("введите количество чисел");

int numberCount = int.Parse(Console.ReadLine()!);
Console.WriteLine(CountPisitiveNumbers(numberCount));

int CountPisitiveNumbers(int numberCount)
{
    int counter = 0;
    for (int i = 0; i < numberCount; i++)
    {
        int currentNumber = int.Parse(Console.ReadLine()!);

        if (IsPositive(currentNumber))
        {
            counter++;
        }
    }
    return counter;
}

bool IsPositive(int number)
{
    if (number > 0)
    {
        return true;
    }
    else
    {
        return false;
    }

}
