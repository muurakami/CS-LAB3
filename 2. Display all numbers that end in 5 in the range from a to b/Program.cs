// 2. Вывести на экран все числа, которые заканчиваются на 5, в диапазоне от a до b.



class Program
{
    static void Main()
    {
        // Запрос пользователю ввести начало (a) и конец (b) диапазона
        Console.Write("Введите начало диапазона (a): ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Введите конец диапазона (b): ");
        int b = int.Parse(Console.ReadLine());

        // Проверка на случай, если a больше b
        if (a > b)
        {
            Console.WriteLine("Начало диапазона не может быть больше конца диапазона.");
            return; // Выходим из программы
        }

        // Используем цикл for для перебора чисел от a до b
        for (int number = a; number <= b; number++)
        {
            // Проверяем, заканчивается ли текущее число на 5
            if (number % 10 == 5)
            {
                // Если число заканчивается на 5, выводим его на экран
                Console.WriteLine(number);
            }
        }
    }
}
