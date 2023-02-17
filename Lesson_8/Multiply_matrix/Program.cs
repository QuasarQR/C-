// n и m - размерности первой матрицы. m и p - размерности второй матрицы. n и p - результат произведения матриц из n строк и p столбцов
 int n = 6, m = 4, p = 6;

// Создание и заполнение первой матрицы случайными числами от 1 до 9
int[,] matrix1 = new int[n, m];
Random random = new Random();
for (int i = 0; i < n; i++)
{
   for (int j = 0; j < m; j++)
   {
      matrix1[i, j] = random.Next(1, 10);
   }
}

// Создание и заполнение второй матрицы случайными числами от 1 до 9
int[,] matrix2 = new int[m, p];
for (int i = 0; i < m; i++)
{
   for (int j = 0; j < p; j++)
   {
      matrix2[i, j] = random.Next(1, 10);
   }
}

// Создание новой матрицы, которая будет результатом умножения matrix1 и matrix2
int[,] result = new int[n, p];

// Проверка, что число столбцов первой матрицы равно числу строк второй матрицы
if (m != matrix2.GetLength(0))
{
   Console.WriteLine("Невозможно умножить матрицы, т.к. число столбцов первой матрицы не равно числу строк второй матрицы.");
   return;
}
for (int i = 0; i < n; i++)
{
   for (int j = 0; j < p; j++)
   {
      int sum = 0;
      for (int k = 0; k < m; k++)
      {
         sum += matrix1[i, k] * matrix2[k, j];
      }
      result[i, j] = sum;
   }
   }

for (int i = 0; i < n; i++)
{
   for (int j = 0; j < p; j++)
   {
      Console.Write(result[i, j] + " ");
   }
   Console.WriteLine();
}
