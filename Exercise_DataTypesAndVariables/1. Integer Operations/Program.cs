int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());
int num4 = int.Parse(Console.ReadLine());

long firstSum = (long)num1 + num2;
long secondSum = firstSum / num3;
long finalResult = secondSum * num4;
Console.WriteLine(finalResult);

