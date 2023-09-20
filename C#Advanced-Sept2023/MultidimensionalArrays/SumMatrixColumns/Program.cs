﻿



int[] rowscols = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

int rows = rowscols[0];
int cols = rowscols[1];


int[,] matrix = new int[rows, cols];

int sum = 0;

for (int i = 0; i < rows; i++)
{
    Queue<int> els = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse));

    for (int j = 0; j < cols; j++)
    {
        matrix[i, j] = els.Dequeue();
    }
}

for (int i = 0; i < cols; i++)
{
    for (int j = 0;j < rows; j++)
    {
        sum += matrix[j, i];
    }
    Console.WriteLine(sum);
    sum = 0;
}