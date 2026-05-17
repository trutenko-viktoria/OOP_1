using System;

namespace ConsoleLab6
{
    class SmartAssistant : SmartTV
    {
        // Закрите поле
        private string assistantMode;

        // Властивість
        public string AssistantMode
        {
            get { return assistantMode; }
            set { assistantMode = value; }
        }

        // Конструктор
        public SmartAssistant(
            string brand,
            string model,
            Display display,
            Processor processor,
            Memory memory,
            NetworkModule network,
            AudioSystem audio,
            string assistantMode)

            : base(
                  brand,
                  model,
                  display,
                  processor,
                  memory,
                  network,
                  audio)
        {
            this.assistantMode = assistantMode;
        }

        // Новий метод
        public void StartTraining()
        {
            Console.WriteLine(
                $"Training mode: {assistantMode}");
        }

        // Новий метод
        public void Show3DModel()
        {
            Console.WriteLine(
                "3D model visualization started.");
        }
    }
}
