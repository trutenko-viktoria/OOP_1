using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLab6
{
    class Display
    {
        // Закриті поля
        private string type;
        private int size;

        // Властивості
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public int Size
        {
            get { return size; }
            set { size = value; }
        }

        // Конструктор
        public Display(string type, int size)
        {
            this.type = type;
            this.size = size;
        }

        // Метод
        public void ShowInfo()
        {
            Console.WriteLine($"Display: {type}, {size} inches");
        }
    }
}
