int startCharecter = int.Parse(Console.ReadLine());
int endCharecter = int.Parse(Console.ReadLine());

for (int i = startCharecter; i <= endCharecter; i++)
{
    char currSymbol = (char)i;
    Console.Write($"{currSymbol} ");
}
