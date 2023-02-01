using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3
{
    class Program
    {
        static void Main (string[] args)
        {
            for(; ; )
            {
                Console.WriteLine("Давай поиграем! Какую игру хочешь выбрать?");
                Console.WriteLine("Введи номер твоего ответа, где:");
                Console.WriteLine("q - Выход");
                Console.WriteLine("0 - Определение четного или нечетного числа");
                Console.WriteLine("1 - Подсчет суммы карт");
                Console.WriteLine("2 - Проверка простого числа");
                Console.WriteLine("3 - Наименьший элемент в последовательности");
                Console.WriteLine("4 - Игра «Угадай число»");

                string answer = Console.ReadLine();
                if(answer == "q") break;
                switch(answer)
                {
                    case "0":
                        #region Определение четного или нечетного числа
                        for(; ; )
                        {
                            Console.WriteLine("Введите целое число... или q - выход в меню.");
                            string enteredStringNumber = Console.ReadLine();
                            int enteredIntNumber;

                            if(enteredStringNumber == "q") break;

                            if(int.TryParse(enteredStringNumber, out enteredIntNumber))
                            {
                                if(enteredIntNumber % 2 == 0)
                                {
                                    Console.WriteLine("Это число чётное!");
                                }
                                else
                                {
                                    Console.WriteLine("Это число не чётное!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Неверная запись. Пожалуйста, давайте повторим");
                            }
                            Console.ReadLine();
                        }
                        #endregion
                        break;
                    case "1":
                        # region Подсчет суммы карт
                        for(; ; )
                        {
                            Console.WriteLine("Привет! Для начала скажи, сколько у тебя карт?");
                            int counter = int.Parse(Console.ReadLine());
                            Console.WriteLine("Введи номинал первой карты");
                            int totalpoints = 0;
                            for (int i = 0; i < counter; i++)
                            {
                                if (i != 0) Console.WriteLine("Введи номинал следующей карты");

                                switch(Console.ReadLine())
                                {
                                    case "2":
                                        totalpoints += 2;
                                        break;
                                    case "3":
                                        totalpoints += 3;
                                        break;
                                    case "4":
                                        totalpoints += 4;
                                        break;
                                    case "5":
                                        totalpoints += 5;
                                        break;
                                    case "6":
                                        totalpoints += 6;
                                        break;
                                    case "7":
                                        totalpoints += 7;
                                        break;
                                    case "8":
                                        totalpoints += 8;
                                        break;
                                    case "9":
                                        totalpoints += 9;
                                        break;
                                    case "10":
                                        totalpoints += 10;
                                        break;
                                    case "J":
                                        totalpoints += 10;
                                        break;
                                    case "Q":
                                        totalpoints += 10;
                                        break;
                                    case "K":
                                        totalpoints += 10;
                                        break;
                                    case "T":
                                        totalpoints += 10;
                                        break;
                                    default:
                                        Console.WriteLine("Неправильная запись, попробуй ещё");
                                        i--;
                                        continue;
                                }

                            }
                            Console.WriteLine($"У тебя {totalpoints} очков");
                            Console.ReadLine();
                            Console.WriteLine("q - для выходя в меню \nЛюбой ввод, чтобы повторить");

                            if (Console.ReadLine() == "q") break;
                        }
                        #endregion
                        break;
                    case "2":
                        #region Проверка простого числа
                        for (; ; )
                        {
                            Console.WriteLine("Введите число для проверки... или q для выхода");
                            string enteredStringNumber = Console.ReadLine();
                            int enteredIntNumber;

                            if(enteredStringNumber == "q") break;

                            if(int.TryParse(enteredStringNumber, out enteredIntNumber))
                            {
                                bool answerBool = true;
                                for(int i = 2; i < enteredIntNumber/2 + 1; i++)
                                {
                                    if (enteredIntNumber%i == 0)
                                    {
                                        answerBool = false;
                                        break;
                                    }
                                }
                                if (answerBool)
                                {
                                    Console.WriteLine("Это число простое");
                                }
                                else
                                {
                                    Console.WriteLine("Это число не простое");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Нет, ну это издевательство какое-то! Попросили же ввести целое число!");
                            }
                            Console.ReadKey();
                        }
                        #endregion
                        break;
                    case "3":
                        #region Наименьший элемент в последовательности
                        for(; ; )
                        {
                            Console.WriteLine("Введи длину последовательности... или q для выхода в меню");
                            string enteredString = Console.ReadLine();
                            int sequenceLength;

                            if(enteredString == "q") break;

                            if(int.TryParse(enteredString, out sequenceLength))
                            {
                                int minValue = int.MaxValue;
                                for (int i = 0; i < sequenceLength; i++)
                                {
                                    int enterValue;
                                    Console.WriteLine("Пожалуйста, введите целое число");
                                    if (int.TryParse(Console.ReadLine(),out enterValue))
                                    {
                                        if(minValue > enterValue)
                                        {
                                            minValue = enterValue;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Эта запись не верна!");
                                        Console.ReadLine();
                                        i--;
                                    }
                                }
                                Console.WriteLine($"{ minValue } является наименьшим в введенной последовательности!");
                            }
                            else
                            {
                                Console.WriteLine("Это специально? Неверная запись. Пожалуйста, давайте повторим");
                            }
                            Console.ReadLine();
                        }
                        #endregion
                        break;
                    case "4":
                        #region Игра «Угадай число»
                        for(; ; )
                        {
                            Console.WriteLine("Поиграем!? \nВведи максимальное число выборки или q для выход в меню.");
                            string enteredStringNumber = Console.ReadLine();
                            int enteredIntNumber;

                            if(enteredStringNumber == "q") break;

                            if(int.TryParse(enteredStringNumber, out enteredIntNumber))
                            {
                                Random rand = new Random();
                                int randomValue = rand.Next(0, enteredIntNumber+1);     // +1, чтобы число входило в диапазон
                                                                                        // (так как в задаче сказано, что пользователь
                                                                                        // вводит МАКСИМАЛЬНОЕ число)
                                Console.WriteLine("Вводите числа в выбранном диапазоне. " +
                                    "\nПопытайтесь найти загаданное нами число " +
                                    "\nза наименьшее количество попыток");
                                int numberOfAttempts = 0;
                                while(true)
                                {
                                    Console.WriteLine("Введите предполагаемое число");
                                    int enteredValue;

                                    if (int.TryParse(Console.ReadLine(), out enteredValue))
                                    {
                                        numberOfAttempts++;
                                        if (enteredValue > randomValue)
                                        {
                                            Console.WriteLine("Введенное число больше, пробуем еще");
                                        }
                                        else if (enteredValue < randomValue)
                                        {
                                            Console.WriteLine("Введенное число меньше, пробуем еще");
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Победа! \nЗагаданное число - {randomValue}\nПопыток - {numberOfAttempts}");
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Что ж... Загаданное число - {randomValue}");
                                        break;
                                    }
                                }
                            } 
                            else
                            {
                                Console.WriteLine($"Пожалуйста, давайте не будем шутить!");
                            }
                            Console.ReadLine();
                        }
                        #endregion
                        break;
                    default:
                        Console.WriteLine($"Пожалуйста, давайте не будем шутить! <{answer}> не похоже на то, что мы просили ввести!");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
