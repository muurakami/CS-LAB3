
class Program
{
    static void Main()
    {
        // Запрос пользователю ввести количество чисел в последовательности
        Console.Write("Введите количество чисел в последовательности: ");
        int sequenceLength = int.Parse(Console.ReadLine());

        // Инициализация переменной для хранения максимального числа, кратного 5
        int maxMultipleOf5 = 0;

        // Цикл для ввода чисел и поиска максимального числа, кратного 5
        for (int i = 0; i < sequenceLength; i++)
        {
            Console.Write($"Введите число #{i + 1}: ");
            int number = int.Parse(Console.ReadLine());

            // Проверяем, кратно ли введенное число 5 и больше текущего максимального числа
            if (number % 5 == 0 && number > maxMultipleOf5)
            {
                maxMultipleOf5 = number; // Обновляем максимальное число, если условие выполняется
            }
        }

        // Выводим найденное максимальное число, кратное 5
        Console.WriteLine($"Максимальное число, кратное 5: {maxMultipleOf5}");
    }
}
