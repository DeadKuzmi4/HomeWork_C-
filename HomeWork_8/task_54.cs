// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2







        // Задаем размеры массива
        int rows = 3;
        int columns = 4;

       
        Random random = new Random();

        // Создаем двумерный массив
        int[,] array = new int[rows, columns];

        // Заполняем массив случайными значениями
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[i, j] = random.Next(1, 100); 
            }
        }

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        Console.WriteLine("Массив с упорядоченными элементами:");
        SortRows(array);
        PrintArray(array);
    

    void SortRows(int[,] array)
    {
        int rowCount = array.GetLength(0);
        int columnCount = array.GetLength(1);

        for (int i = 0; i < rowCount; i++)
        {
            for (int j = 0; j < columnCount - 1; j++)
            {
                for (int k = j + 1; k < columnCount; k++)
                {
                    if (array[i, j] < array[i, k])
                    {
                        int temp = array[i, j];
                        array[i, j] = array[i, k];
                        array[i, k] = temp;
                    }
                }
            }
        }
    }

    static void PrintArray(int[,] array)
    {
        int rowCount = array.GetLength(0);
        int columnCount = array.GetLength(1);

        for (int i = 0; i < rowCount; i++)
        {
            for (int j = 0; j < columnCount; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

