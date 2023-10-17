// 5. *Напишите программу «Тренажер таблицы умножения».
//На экран выводятся 2 случайных числа: 2 * 5 =
//Пользователь вводит ответ, после которого программа выдает результат «Верно\Неверно» и вопрос «Продолжить? Д\Н». Если пользователь вводит «Н», игра останавливается программа выводит результат в виде: 
//Всего попыток – 5
//Верных ответов – 4 (90,7%)
//Неверных – 1 (9,3%).


class Program
{
    static void Main(string[] args)
    {
        // Инициализируем генератор случайных чисел.
        Random random = new Random();

        int totalAttempts = 0;     // Общее количество попыток
        int correctAnswers = 0;   // Количество правильных ответов

        // Запускаем бесконечный цикл для тренировки, пока пользователь не решит выйти.
        while (true)
        {
            // Генерируем два случайных числа от 1 до 10.
            int num1 = random.Next(1, 11);
            int num2 = random.Next(1, 11);

            Console.Write($"{num1} * {num2} = ");
            int userAnswer = int.Parse(Console.ReadLine());

            // Подсчитываем общее количество попыток и правильных ответов.
            totalAttempts++;
            if (userAnswer == num1 * num2)
            {
                correctAnswers++;
                Console.WriteLine("Верно!");
            }
            else
            {
                Console.WriteLine("Неверно.");
            }

            // Спрашиваем пользователя, хочет ли он продолжить.
            Console.Write("Продолжить? (Д/Н): ");
            char continueChoice = char.ToUpper(Console.ReadKey().KeyChar);

            // Если пользователь выбрал "Н", завершаем цикл.
            if (continueChoice == 'Н')
                break;

            Console.WriteLine();  // Пустая строка для форматирования вывода.
        }

        // Выводим статистику по окончании тренировки.
        Console.WriteLine($"\nВсего попыток – {totalAttempts}");
        Console.WriteLine($"Верных ответов – {correctAnswers} ({(double)correctAnswers / totalAttempts:P})");
        Console.WriteLine($"Неверных – {totalAttempts - correctAnswers} ({(double)(totalAttempts - correctAnswers) / totalAttempts:P})");
    }
}

