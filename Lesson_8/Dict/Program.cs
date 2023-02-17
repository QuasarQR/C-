int[,] arr = new int[5, 5]
{
   { 1, 2, 3, 4, 5 },
   { 1, 3, 2, 4, 2 },
   { 5, 4, 3, 2, 1 },
   { 3, 3, 3, 3, 3 },
   { 2, 2, 2, 2, 2 }
};

Dictionary<int, int> frequency = new Dictionary<int, int>();

for (int i = 0; i < arr.GetLength(0); i++)
{
   for (int j = 0; j < arr.GetLength(1); j++)
   {
      int element = arr[i, j];

      if (frequency.ContainsKey(element))
      {
         frequency[element]++;
      }
      else
      {
      frequency[element] = 1;
      }
   }
}

Console.WriteLine("Частотный словарь:");
foreach (KeyValuePair<int, int> pair in frequency)
{
   Console.WriteLine("Элемент {0} встречается в массиве {1} раз.", pair.Key, pair.Value);
}





