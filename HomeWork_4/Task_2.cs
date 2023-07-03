// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр равна {GetSum(number)}");

int GetSum(int number){
    int sum = 0;
    while (number != 0){
        int digit = number % 10;
        sum += digit;
        number /= 10;
    }
    return sum;
}