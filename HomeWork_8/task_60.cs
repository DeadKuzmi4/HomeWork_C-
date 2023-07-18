// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)






int[,,] array = CreateArray();
PrintArray(array);


int[,,] CreateArray()
{
    int[,,] array = new int[2, 2, 2];
    int number = 10;

    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            for (int k = 0; k < 2; k++)
            {
                array[i, j, k] = number++;
            }
        }
    }

    return array;
}

void PrintArray(int[,,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int depths = array.GetLength(2);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < depths; k++)
            {
                Console.WriteLine("{0}({1},{2},{3})", array[i, j, k], i, j, k);
            }
        }
    }
}

