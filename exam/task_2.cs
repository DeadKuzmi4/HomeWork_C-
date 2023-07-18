// Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30



Console.WriteLine("Введите число M:");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine());

int sum = CalculateSum(M, N);

Console.WriteLine("Сумма натуральных чисел от {0} до {1}: {2}", M, N, sum);


static int CalculateSum(int start, int end)
{
    if (end < start)
        return 0;

    return start + CalculateSum(start + 1, end);
}

