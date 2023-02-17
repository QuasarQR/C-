int[,,] arr = new int[4, 4, 4];
Random rand = new Random();

for (int i = 0; i < 4; i++)
{
   for (int j = 0; j < 4; j++)
   {
      for (int k = 0; k < 4; k++)
      {
         int num;
         do
         {
            num = rand.Next(10, 100);
         } while (IsDuplicate(arr, num));

         arr[i, j, k] = num;
         Console.WriteLine($"arr[{i}, {j}, {k}] = {num}");
      }
   }
}

static bool IsDuplicate(int[,,] arr, int num)
{
   foreach (int n in arr)
   {
      if (n == num)
      {
         return true;
      }
   }
   return false;
}
