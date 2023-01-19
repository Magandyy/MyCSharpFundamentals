int number = int.Parse(Console.ReadLine());
int total = 0;

bool isSpecialNumber = false;
for (int i = 1; i <= number; i++)
{
    int currNum = i;
    while (i > 0)
    {
        total += i % 10;
        i = i / 10;
    }
    isSpecialNumber = (total == 5) || (total == 7) || (total == 11);
    Console.WriteLine("{0} -> {1}", currNum, isSpecialNumber);
    total = 0;
    i = currNum;
}

