namespace Game
{
    class GuessingGame
    {
        static void Main(string[] args)
        {
            // Создаем экземпляр класса Random для генерации случайного числа
            Random rand = new Random();

            // Генерируем случайное число от 1 до 100 и сохраняем его в переменную answer
            int answer = rand.Next(1, 101);

            // Инициализируем переменные для отслеживания количества попыток и последнего введенного числа
            int guess = 0;
            int attempts = 0;

            // Выводим сообщение с просьбой угадать число от 1 до 100
            Console.WriteLine("Guess the number between 1 and 100.");

            // Запускаем цикл, который будет продолжаться, пока не будет угадано число
            while (guess != answer)
            {
                // Просим пользователя ввести число
                Console.Write("Enter your guess: ");

                // Считываем введенное пользователем число и преобразуем его в целое число
                guess = int.Parse(Console.ReadLine());

                // Увеличиваем счетчик попыток
                attempts++;

                // Проверяем, было ли введенное число меньше или больше загаданного
                if (guess < answer)
                {
                    // Выводим сообщение, что число слишком маленькое
                    Console.WriteLine("Too low, try again.");

                }
                else if (guess > answer)
                {
                    // Выводим сообщение, что число слишком большое
                    Console.WriteLine("Too high, try again.");

                }
            }

            // Если цикл закончился, значит пользователь угадал число. Выводим поздравление и количество попыток
            Console.WriteLine("Congratulations! You guessed the number in " + attempts + " attempts.");
        }
    }
}