// 7. *Вывести все простые числа в диапазоне [a,b];

class Program
{
    static void Main()
    {
        // Запрос у пользователя ввести начало (a) и конец (b) диапазона
        Console.Write("Введите начало диапазона (a): ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Введите конец диапазона (b): ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine($"Простые числа в диапазоне от {a} до {b}:");

        for (int number = a; number <= b; number++)
        {
            if (IsPrime(number))
            {
                Console.Write(number + " "); // Выводим простое число
            }
        }
    }

    // Функция для проверки, является ли число простым
    static bool IsPrime(int n)
    {
        if (n <= 1)
        {
            return false; // Числа меньше или равные 1 не считаются простыми
        }

        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0)
            {
                return false; // Если число делится нацело на другое число, оно не простое
            }
        }

        return true; // Если не было делителей, кроме 1 и самого числа, оно простое
    }
}
