int lines = int.Parse(Console.ReadLine());

int totalSum = 0;
for (int i = 1; i <= lines; i++)
{
    char letter = char.Parse(Console.ReadLine());
    totalSum += (int)letter;
    
}
Console.WriteLine($"The sum equals: {totalSum}");