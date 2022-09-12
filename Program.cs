Console.WriteLine ();
Console.WriteLine("Таблица умножения:");
Console.WriteLine ();
for (int i = 2; i <= 10; i++)
{
    Console.WriteLine($"Умножение на {i}");
    Console.WriteLine();
    for (int j = 2; j <=10; j++)
        {
            Console.WriteLine($"{i} X {j} = {i*j}");
        }
        Console.WriteLine ();  
}