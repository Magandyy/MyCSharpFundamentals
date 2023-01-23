int power = int.Parse(Console.ReadLine());
int distance = int.Parse(Console.ReadLine());
int exhaustionFactor = int.Parse(Console.ReadLine());

int targetsCount = 0;

int currPower = power;
while (currPower >= distance)
{
    if (currPower == 0.5 * power && exhaustionFactor != 0)
    {
        currPower /= exhaustionFactor;
        if (currPower < distance)
        {
            break;
        }
    }
    currPower -= distance;
    targetsCount++;
}
Console.WriteLine($"{currPower}\r\n{targetsCount}");