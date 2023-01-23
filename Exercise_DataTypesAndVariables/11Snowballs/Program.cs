using System.Numerics;

int number = int.Parse(Console.ReadLine());

BigInteger maxValue = BigInteger.MinusOne;
BigInteger snowballValue = 0;
int snow = 0;
int time = 0;
int quality = 0;
for (int i = 1; i <= number; i++)
{
    int snowballSnow = int.Parse(Console.ReadLine());
    int snowballTime = int.Parse(Console.ReadLine());
    int snowballQuality = int.Parse(Console.ReadLine());

    snowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);
    if(snowballValue > maxValue)
    {
        maxValue = snowballValue;
        snow = snowballSnow;
        time = snowballTime;
        quality = snowballQuality;
    }
}
Console.WriteLine($"{snow} : {time} = {maxValue} ({quality})");