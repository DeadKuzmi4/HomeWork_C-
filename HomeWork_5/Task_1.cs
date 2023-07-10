// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.

class Program
{
    static void Main()
    {
        // Создаем массив случайных трехзначных чисел
        int[] numbers = GenerateRandomNumbers(4);

        // Подсчитываем количество четных чисел в массиве
        int evenCount = CountEvenNumbers(numbers);

        // Выводим результат

        Console.WriteLine("Количество четных чисел: " + evenCount);
    }

    static int[] GenerateRandomNumbers(int count)
    {
        Random random = new Random();
        int[] numbers = new int[count];
        
        for (int i = 0; i < count; i++)
        {
            numbers[i] = random.Next(100, 1000); // Генерируем трехзначное число
        }
        
        return numbers;
    }

    static int CountEvenNumbers(int[] numbers)
    {
        int count = 0;
        
        foreach (int number in numbers)
        {
            if (number % 2 == 0) // Проверяем, является ли число четным
            {
                count++;
            }
        }
        
        return count;
    }
}