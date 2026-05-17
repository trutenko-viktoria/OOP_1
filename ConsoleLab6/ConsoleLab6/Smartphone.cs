using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLab6
{
    class Smartphone
    {
        // Закрите поле
        private string owner;

        // Властивість
        public string Owner
        {
            get { return owner; }
            set { owner = value; }
        }

        // Конструктор
        public Smartphone(string owner)
        {
            this.owner = owner;
        }

        // Метод
        public void ControlTV(SmartTV tv)
        {
            Console.WriteLine($"{owner} controls Smart TV.");

            tv.OpenBrowser();
        }
    }
}
