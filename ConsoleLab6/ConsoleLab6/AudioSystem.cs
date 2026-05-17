using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLab6
{
    //агрегація
    class AudioSystem
    {
        // Закриті поля
        private int volume;
        private int speakers;

        // Властивості
        public int Volume
        {
            get { return volume; }
            set { volume = value; }
        }

        public int Speakers
        {
            get { return speakers; }
            set { speakers = value; }
        }

        // Конструктор
        public AudioSystem(int volume, int speakers)
        {
            this.volume = volume;
            this.speakers = speakers;
        }

        // Метод
        public void IncreaseVolume()
        {
            volume++;

            Console.WriteLine($"Volume: {volume}");
        }

        // Метод
        public void ShowInfo()
        {
            Console.WriteLine($"Speakers: {speakers}");
            Console.WriteLine($"Volume: {volume}");
        }
    }
}
