int lines = int.Parse(Console.ReadLine());

int capacity = 255;
int waterQuantity = 0;
for (int i = 1; i <= lines; i++)
{
    int liters = int.Parse(Console.ReadLine());

    if(liters > capacity)
    {
        Console.WriteLine("Insufficient capacity!");
        continue;
    }
    capacity -= liters;
    waterQuantity += liters;
}
Console.WriteLine(waterQuantity);
