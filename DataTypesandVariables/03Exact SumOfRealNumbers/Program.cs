﻿int n = int.Parse(Console.ReadLine());

decimal sum = 0m;
for (int i = 1; i <= n; i++)
{
    decimal currNum = decimal.Parse(Console.ReadLine());
    sum += currNum;
}
Console.WriteLine(sum);