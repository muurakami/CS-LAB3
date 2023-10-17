// 4. Определить, является ли введенное с клавиатуры число простым.

class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());

        bool isPrime = IsPrime(number); // Вызываем функцию для проверки простоты числа

        if (isPrime)
        {
            Console.WriteLine($"{number} - простое число.");
        }
        else
        {
            Console.WriteLine($"{number} - не является простым числом.");
        }
    }

    // Функция для проверки простоты числа
    static bool IsPrime(int n)
    {
        if (n <= 1)
        {
            return false; // Если число меньше или равно 1, оно не является простым
        }

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                return false; // Если число делится нацело на какое-то число от 2 до корня из n, оно не простое
            }
        }

        return true; // Если не было делителей, кроме 1 и самого числа, оно простое
    }
}
