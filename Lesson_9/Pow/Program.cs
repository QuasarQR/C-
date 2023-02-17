int a = 3;
int b = 5;
int result = Power(a, b);
Console.WriteLine($"{a} в степени {b} равно {result}");

int Power(int a, int b)
{
    if (b == 0)
    {
        return 1;
    }
    else if (b % 2 == 0)
    {
        int tmp = Power(a, b / 2);
        return tmp * tmp;
    }
    else
    {
        int tmp = Power(a, (b - 1) / 2);
        return a * tmp * tmp;
    }
}
