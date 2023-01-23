int beerKegsCnt = int.Parse(Console.ReadLine());

double maxVolume = double.MinValue;
string biggestKeg = string.Empty;
for (int i = 1; i <= beerKegsCnt; i++)
{
    string model = Console.ReadLine();
    double radius = double.Parse(Console.ReadLine());
    int height = int.Parse(Console.ReadLine());

    double volume = Math.PI * Math.Pow(radius, 2) * height;
    if(volume > maxVolume)
    {
        maxVolume = volume;
        biggestKeg = model;
    }
}
Console.WriteLine(biggestKeg);