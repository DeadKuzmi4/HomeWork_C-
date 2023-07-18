// Напишите программу вычисления функции Аккермана 
//с помощью рекурсии. Даны два неотрицательных числа m и n. Выполнить с помощью рекурсии.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите число m:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());

int result = CalculateAckermann(m, n);

Console.WriteLine("A({0}, {1}) = {2}", m, n, result);


int CalculateAckermann(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0)
        return CalculateAckermann(m - 1, 1);
    else
        return CalculateAckermann(m - 1, CalculateAckermann(m, n - 1));
}
