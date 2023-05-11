using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ElevenLabaDelegati
{
    public class DirectionEventArgs : EventArgs
    {
        public string Direction { get; }

        public DirectionEventArgs(string direction)
        {
            Direction = direction;
        }
    }
    class Robot
    {
        public event EventHandler<DirectionEventArgs> DirectionChosen;

        private readonly string[] directions = { "вперед", "назад", "влево", "вправо" };
        private readonly Random random = new Random();
        public void Start()
        {
            while (true)
            {
                var direction = directions[random.Next(directions.Length)];
                Console.WriteLine($"Направление: {direction}");

                if (direction == "назад")
                {
                    OnDirectionChosen(direction);
                }
                System.Threading.Thread.Sleep(1000);
            }
        }
        protected virtual void OnDirectionChosen(string direction)
        {
            DirectionChosen?.Invoke(this, new DirectionEventArgs(direction));
        }
    }
}
