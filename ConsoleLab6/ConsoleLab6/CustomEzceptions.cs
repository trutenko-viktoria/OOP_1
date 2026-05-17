using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLab6
{
    // Власне виключення
    class InternetException : Exception //InternetException наслідується від Exception
    {
        public InternetException(string message) //дозволяє передавати текст помилки.
            : base(message) //передає повідомлення в стандартний Exception.
        {
        }
    }
}
