int number = int.Parse(Console.ReadLine());

int sum = 0;
int currNum = number;
while (currNum > 0)
{
    int lastDigit = currNum % 10;
    currNum /= 10;
    sum += lastDigit;
}
Console.WriteLine(sum);