int[] sourceArray = { 1, 2, 3, 4, 5 };
int[] destinationArray = new int[sourceArray.Length];

Console.WriteLine("Был задан массив: {1, 2, 3, 4, 5}");
for (int i = 0; i < sourceArray.Length; i++)
{
    destinationArray[i] = sourceArray[i];
}

Console.WriteLine("Скопированный массив: ");
foreach (int number in destinationArray)
{
    Console.Write(number + " ");
}