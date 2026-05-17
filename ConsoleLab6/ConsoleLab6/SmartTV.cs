using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLab6
{
    class SmartTV
    {
        public delegate void TVHandler(string message); //створює тип для методів.

        public event TVHandler TVTurnedOff;  //створює подію

        // Закриті поля
        private string brand;
        private string model;

        // КОМПОЗИЦІЯ
        private Display display; //передаємо готовий об'єкт Displey в smartTV
        private Processor processor;
        private Memory memory;
        private NetworkModule network;

        // АГРЕГАЦІЯ
        private AudioSystem audio;

        // Властивості
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        // Конструктор
        public SmartTV(
            string brand,
            string model,
            Display display,
            Processor processor,
            Memory memory,
            NetworkModule network,
            AudioSystem audio)
        {
            this.brand = brand;
            this.model = model;

            this.display = display;
            this.processor = processor;
            this.memory = memory;
            this.network = network;

            this.audio = audio;
        }

        // Метод
        public void WatchYouTube()
        {
            Console.WriteLine("Opening YouTube...");
        }

        // Метод
        public void OpenBrowser()
        {
            Console.WriteLine("Browser started.");
        }

        // Метод
        public void PlayGame()
        {
            Console.WriteLine("Game launched.");
        }

        // Метод
        public void SendMessage()
        {
            Console.WriteLine("Message sent.");
        }

        // Метод
        public void RecordVideo(string fileName)
        {
            memory.SaveFile(fileName);

            Console.WriteLine("Video recorded.");
        }

        // Метод
        public void ShowInfo()
        {
            Console.WriteLine($"Smart TV: {brand} {model}");

            display.ShowInfo();
            processor.ShowInfo();
            memory.ShowInfo();
            network.ShowInfo();
            audio.ShowInfo();
        }

        public void TurnOff()
        {
            Console.WriteLine("Smart TV turned off.");

            TVTurnedOff?.Invoke( //викликає подію
                "Warning: TV was turned off remotely."
            );
        }
    }
}
