using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLab6
{
    class Memory
    {
        // Закриті поля
        private int ram;
        private int storage;

        // Властивості
        public int Ram
        {
            get { return ram; }
            set { ram = value; }
        }

        public int Storage
        {
            get { return storage; }
            set { storage = value; }
        }

        // Конструктор
        public Memory(int ram, int storage)
        {
            this.ram = ram;
            this.storage = storage;
        }

        // Метод
        public void SaveFile(string fileName)
        {
            Console.WriteLine($"File {fileName} saved.");
        }

        // Метод
        public void ShowInfo()
        {
            Console.WriteLine($"RAM: {ram} GB");
            Console.WriteLine($"Storage: {storage} GB");
        }
    }
}
