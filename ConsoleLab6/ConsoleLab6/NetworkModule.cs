using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLab6
{
    class NetworkModule
    {
        // Закриті поля
        private bool wifiEnabled;
        private bool bluetoothEnabled;
        private bool lanConnected;

        // Властивості
        public bool WifiEnabled
        {
            get { return wifiEnabled; }
            set { wifiEnabled = value; }
        }

        public bool BluetoothEnabled
        {
            get { return bluetoothEnabled; }
            set { bluetoothEnabled = value; }
        }

        public bool LanConnected
        {
            get { return lanConnected; }
            set { lanConnected = value; }
        }

        // Конструктор
        public NetworkModule(bool wifi, bool bluetooth, bool lan)
        {
            wifiEnabled = wifi;
            bluetoothEnabled = bluetooth;
            lanConnected = lan;
        }

        // Метод
        public void ConnectToInternet()
        {
            if (wifiEnabled || lanConnected)
            {
                Console.WriteLine("Internet connection successful.");
            }
            else
            {
                throw new InternetException(
                "Internet connection failed."
            );
            }
        }

        // Метод
        public void ShowInfo()
        {
            Console.WriteLine($"WiFi: {wifiEnabled}");
            Console.WriteLine($"Bluetooth: {bluetoothEnabled}");
            Console.WriteLine($"LAN: {lanConnected}");
        }
    }
}
