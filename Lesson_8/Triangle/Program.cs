int n = 10; // число строк треугольника
int[][] pascal = new int[n][];
for (int i = 0; i < n; i++)
{
    pascal[i] = new int[i + 1];
    pascal[i][0] = 1;
    for (int j = 1; j < i; j++)
    {
        pascal[i][j] = pascal[i - 1][j - 1] + pascal[i - 1][j];
    }
    pascal[i][i] = 1;
}

// Вывод треугольника в виде равнобедренного треугольника
for (int i = 0; i < n; i++)
{
    Console.Write(new string(' ', (n - i) * 2));
    for (int j = 0; j <= i; j++)
    {
        Console.Write("{0,4}", pascal[i][j]);
    }
    Console.WriteLine();
}
