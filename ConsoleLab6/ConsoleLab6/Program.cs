using ConsoleLab6;
using System;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Створення компонентів
            Display display =
                new Display("OLED", 55);

            Processor processor =
                new Processor("Intel", 8, 3.5);

            Memory memory =
                new Memory(16, 512);

            NetworkModule network =
                new NetworkModule(true, true, false);

            AudioSystem audio =
                new AudioSystem(20, 4);

            // Створення Smart TV
            SmartTV tv =
                new SmartTV(
                    "Samsung",
                    "Q90",
                    display,
                    processor,
                    memory,
                    network,
                    audio
                );

            // Підписка на подію
            tv.TVTurnedOff += ShowMessage;

            // Інформація
            tv.ShowInfo();

            Console.WriteLine();

            // Робота Smart TV
            tv.WatchYouTube();

            tv.PlayGame();

            tv.RecordVideo("movie.mp4");

            Console.WriteLine();

            // Перевірка Інтернету
            try
            {
                network.ConnectToInternet();
            }
            catch (InternetException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine();

            // Асоціація
            Smartphone phone =
                new Smartphone("Vika");

            phone.ControlTV(tv);

            Console.WriteLine();

            // Наслідування
            SmartAssistant assistant =
                new SmartAssistant(
                    "LG",
                    "VisionPro",
                    display,
                    processor,
                    memory,
                    network,
                    audio,
                    "Pilot training"
                );

            assistant.StartTraining();

            assistant.Show3DModel();

            Console.WriteLine();

            // Подія
            tv.TurnOff();

            Console.WriteLine();

            // Помилка введення
            try
            {
                Console.Write("Enter volume: ");

                int volume =
                    Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input.");
            }

            Console.WriteLine();

            // Вихід за межі масиву
            try
            {
                int[] numbers = new int[3];

                numbers[5] = 10;
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Array index error.");
            }

            Console.ReadKey();
        }

        // Обробник події
        static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}