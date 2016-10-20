using System;
using System.Threading;

namespace ConsoleSaver
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            // Loop for a while 
            for(int i=0; i<10000; i++)
            {               
                String tmp = "";
                int current = rnd.Next(180);
                // Fill and display    
                tmp = tmp.PadRight( current, ' ') + '|';
                Console.WriteLine(tmp);
                Thread.Sleep(100);
            }
        }
    }
}
