using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLab6
{
    class Processor
    {
        // Закриті поля
        private string model;
        private int cores;
        private double frequency;

        // Властивості
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int Cores
        {
            get { return cores; }
            set { cores = value; }
        }

        public double Frequency
        {
            get { return frequency; }
            set { frequency = value; }
        }

        // Конструктор
        public Processor(string model, int cores, double frequency)
        {
            this.model = model;
            this.cores = cores;
            this.frequency = frequency;
        }

        // Метод
        public void ProcessVideo()
        {
            Console.WriteLine("Video processing started...");
        }

        // Метод
        public void ShowInfo()
        {
            Console.WriteLine($"Processor: {model}");
            Console.WriteLine($"Cores: {cores}"); //ядра
            Console.WriteLine($"Frequency: {frequency} GHz"); //частота
        }
    }
}
