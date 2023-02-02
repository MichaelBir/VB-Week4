
int sum = 0;
for (int i = 1; i < 15; i++)
{
    Console.WriteLine($"i = {i}");
    Console.WriteLine($"Current total:{sum}");
    sum = sum + 1;
}

Console.WriteLine($"Final total: {sum} ");