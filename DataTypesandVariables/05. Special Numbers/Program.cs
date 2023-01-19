int n = int.Parse(Console.ReadLine());


for (int i = 1; i <= n; i++)
{
    int currNum = i;
    int sum = 0;
    while (currNum > 0)
    { 
        int lastDigit = currNum % 10;
        currNum /= 10;
        sum += lastDigit;
    }
    
    if(sum == 5 || sum == 7 || sum == 11)
    {
        Console.WriteLine($"{i} -> True");
    }
    else
    {
        Console.WriteLine($"{i} -> False");
    }
}
