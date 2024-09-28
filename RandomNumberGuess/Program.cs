using System.ComponentModel.Design;
using System.Text;

class RandomNumberGenerator
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.Unicode;

        Console.WriteLine("Добро пожаловать в игру 'Угадай число'!");
        Console.WriteLine("Я загадал число между: 1 и 100.");
        Console.WriteLine("Попробуйте угадать. У вас 10 попыток");

        // Создаем объект для генерации чисел
        Random rand = new Random();

        // Создаем переменную для хранения случайного числа
        int random_next = rand.Next(1, 101);

        // Создаем переменную для хранения числа попыток
        int attempt = 0;

        // 1. Создаем цикл, который будет выполняться до тех пор, пока не будет угадано число
        while (attempt < 10)
        {
            attempt++;
            Console.WriteLine("Попытка " + attempt);

            // 2.2. Считываем число с клавиатуры и сохраняем в переменную
            bool resultinput = int.TryParse(Console.ReadLine(), out int result);
            while (!resultinput || result <= 0 || result >= 101)
            {
                Console.Write("Данные некорретны. Введите целое число от 1 до 100: ");
                resultinput = int.TryParse(Console.ReadLine(), out result);
            }

            // 2.3. Сравниваем загаданное число с введенным пользователем
            if (result == random_next)
            {
                // 2.4. Если числа равны, то выводим сообщение о победе и о количестве попыток
                Console.WriteLine("Вы выиграли, угаданное число " + result + " , количество попыток " + attempt);
                break;
            }

            // 2.5. Если число пользователя больше загаданного, то выводим сообщение, что число больше загаданного
            if (result > random_next)
            {
                Console.WriteLine("Число больше загаданного");
            }
            else
            {
                Console.WriteLine("Число меньше загаданного");
            }
        }
                
            Console.WriteLine("Число попыток равно 10. Вы проиграли. Загаданное число было " + random_next);
        }
    }
               

            

