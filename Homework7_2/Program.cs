using System;
using System.Linq;

namespace Homework7_2
{

    struct Train
    {
        public string destinationName;
        public int trainNumber;
        public string departureTime;

        public Train(int trainNumber)
        {
            this.trainNumber = trainNumber;
            this.destinationName = "Пункт призначення не вказано";
            this.departureTime = "Час відправлення не вказано";
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            /*Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
             * Потрібно: Описати структуру з ім'ям Train, що містить такі поля: назву пункту 
             * призначення, номер поїзда, час відправлення. Написати програму, яка виконує такі дії: 
             * введення з клавіатури даних до масиву, що складається з восьми елементів типу Train 
             * (записи мають бути впорядковані за номерами поїздів); виведення на екран інформації
             * про поїзд, номер якого введено з клавіатури (якщо таких поїздів немає, 
             * вивести відповідне повідомлення). */

            Train[] trains = new Train[] { new Train(1), new Train(2), new Train(3), new Train(4), new Train(5), new Train(6), new Train(7), new Train(8) };

            string userInput = "e";
            int currentTrainNumber;
            do
            {
                ShowShedule(trains);
                Console.WriteLine("Введіть номер поїзда ('e' exit):");
                userInput = Console.ReadLine();

                if (userInput == "e")
                {
                    break;
                }


                int.TryParse(userInput, out currentTrainNumber);

                if (currentTrainNumber < 1 || currentTrainNumber > 8)
                {
                    Console.WriteLine("Такого номера не знайдено"); 
                    continue;
                }
                

                currentTrainNumber = currentTrainNumber - 1;
                
                ShowShedule(trains, currentTrainNumber);

                Console.WriteLine("Вкажіть пункт призначення:");
                trains[currentTrainNumber].destinationName = Console.ReadLine();
                ShowShedule(trains, currentTrainNumber);
                
                Console.WriteLine("Вкажіть час відправлення:");
                trains[currentTrainNumber].departureTime = Console.ReadLine();
                ShowShedule(trains, currentTrainNumber);



            } while (userInput != "e");


            Console.WriteLine("Роботу завершено.");
            Console.ReadKey();

        }

        static void ShowShedule( Train[] trains, int editRows = -1 )
        {
            Console.Clear();
            Console.WriteLine("Розклад потягів:");
            for (int i = 0; i < trains.Length; i++)
            {
                if (editRows == i )
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                }
                Console.WriteLine($"{trains[i].trainNumber} | {trains[i].destinationName} | {trains[i].departureTime}");
                Console.ResetColor();
            }
            
        }
    }
}
