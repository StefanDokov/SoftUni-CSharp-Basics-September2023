﻿



int n = int.Parse(Console.ReadLine());
int times = int.Parse(Console.ReadLine());

if (times <= 10)
{
    for (int i = times; i <= 10; i++)
    {
        Console.WriteLine($"{n} X {i} = {n * i}");
    }


}
else
{
    Console.WriteLine($"{n} X {times} = {n * times}");
}