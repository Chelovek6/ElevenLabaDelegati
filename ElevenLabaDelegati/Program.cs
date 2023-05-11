using System;

namespace ElevenLabaDelegati
{
    class Program
    {
        static void Main(string[] args)
        {
            /* bool e = true;
              while (e)
                 {
                     Deligats op = new Deligats();
                     Console.WriteLine("Введите число");
                     double a = double.Parse(Console.ReadLine());
                     op.Print(a);
                 }
         */
            
            
                Robot robot = new Robot();
                FileLog log = new FileLog();


                robot.DirectionChosen += log.LogToFile;


                System.Threading.Thread robotThread = new System.Threading.Thread(robot.Start);
                robotThread.Start();

            
        }
    }
}
