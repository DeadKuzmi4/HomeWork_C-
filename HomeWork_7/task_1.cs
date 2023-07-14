
Console.WriteLine("Введите количество строк :");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов :");
int n = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[m, n]; // Создаем двумерный массив

Random random = new Random();

// Заполняем массив случайными вещественными числами
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = random.NextDouble();
    }
}

// Выводим содержимое массива
Console.WriteLine("Сгенерированный массив:");

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(matrix[i, j].ToString("0.00"));
    }
    Console.WriteLine();
}