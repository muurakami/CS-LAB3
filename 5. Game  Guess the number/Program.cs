// 5. *Напишите программу-игру «Угадай число!». 
//программа формирует случайное число, которое должен  угадать пользователь. если пользователь ввел число, большее загаданного, на экран выводится «перелет!», если меньшее «недолет!», если равное «молодец! в точку!». после верного ответа на экран выводится количество совершенных попыток и вопрос «начать заново? д\н». игра продолжается до тех пор, пока пользователь не ввел «н».

class Program
{
    static void Main()
    {
        Random random = new Random();
        string playAgain = "Д";

        while (playAgain == "Д" || playAgain == "д")
        {
            int secretNumber = random.Next(1, 101); // Загадываем случайное число от 1 до 100
            int attempts = 0;

            Console.WriteLine("Давай сыграем в 'Угадай число!'");

            while (true)
            {
                Console.Write("Угадай число от 1 до 100: ");
                int guess = int.Parse(Console.ReadLine());
                attempts++;

                if (guess < secretNumber)
                {
                    Console.WriteLine("Недолет!");
                }
                else if (guess > secretNumber)
                {
                    Console.WriteLine("Перелет!");
                }
                else
                {
                    Console.WriteLine("Молодец! В точку!");
                    Console.WriteLine($"Ты угадал число с {attempts} попытки!");
                    break;
                }
            }

            Console.Write("Начать заново? (Д/Н): ");
            playAgain = Console.ReadLine();
        }

        Console.WriteLine("Спасибо за игру!");
    }
}
