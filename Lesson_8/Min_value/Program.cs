// Создаем двумерный массив
int[,] matrix = new int[,] { { 3, 2, 4 }, { 7, 1, 5 }, { 8, 6, 9 } };

// Находим минимальный элемент
int min = int.MaxValue;
int minRowIndex = -1;
int minColIndex = -1;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i, j] < min)
        {
            min = matrix[i, j];
            minRowIndex = i;
            minColIndex = j;
        }
    }
}

// Удаляем строку и столбец с наименьшим элементом
int[,] result = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    if (i == minRowIndex) // Пропускаем строку с наименьшим элементом
        continue;

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (j == minColIndex) // Пропускаем столбец с наименьшим элементом
            continue;

        int newRowIndex = i < minRowIndex ? i : i - 1;
        int newColIndex = j < minColIndex ? j : j - 1;

        result[newRowIndex, newColIndex] = matrix[i, j];
    }
}

// Выводим результат
for (int i = 0; i < result.GetLength(0); i++)
{
    for (int j = 0; j < result.GetLength(1); j++)
    {
        Console.Write(result[i, j] + " ");
    }
    Console.WriteLine();
}
