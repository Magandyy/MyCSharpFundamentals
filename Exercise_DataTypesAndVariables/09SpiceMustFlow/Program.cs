uint spicesQuantity = uint.Parse(Console.ReadLine());

int days = 0;
uint totalAmount = 0;
while (spicesQuantity >= 100)
{
    uint extract = spicesQuantity;
    extract -= 26;
    totalAmount += extract;
    spicesQuantity -= 10;
    days++;
}
if(totalAmount >= 26)
{ 
    totalAmount -= 26;
}
Console.WriteLine($"{days}\r\n{totalAmount}");

