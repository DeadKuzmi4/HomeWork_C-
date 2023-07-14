Console.WriteLine("Введите количество строк:");
int rowCount = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов:");
int columnCount = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rowCount, columnCount]; // Создаем двумерный массив

Random random = new Random();

// Заполняем массив случайными числами
for (int i = 0; i < rowCount; i++)
{
    for (int j = 0; j < columnCount; j++)
    {
        array[i, j] = random.Next(1, 100); // Заполняем случайными числами от 1 до 100
    }
}

// Находим среднее арифметическое для каждого столбца
double[] columnAverages = new double[columnCount];

for (int j = 0; j < columnCount; j++)
{
    int sum = 0;
    for (int i = 0; i < rowCount; i++)
    {
        sum += array[i, j];
    }
    columnAverages[j] = (double)sum / rowCount;
}

// Выводим средние значения столбцов
Console.WriteLine("Средние значения столбцов:");

for (int j = 0; j < columnCount; j++)
{
    Console.WriteLine("Столбец {0}: {1}", j, columnAverages[j]);
}
