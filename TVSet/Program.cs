using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSet
{
    class Program
    {
        static void Main(string[] args)
        {           
            Random random = new Random();
            TV tv = new TV();

            string[] channels = new string[20];

            for (int i = 0; i < channels.Length; i++)
            {
                int randomNumber = random.Next(1, 100);
                
                if(randomNumber % 2 == 0)
                {
                    channels[i] = "On";
                }
                else
                {
                    channels[i] = "Off";
                }
            }
            for (int i = 0; i < channels.Length; i++)
            {
                
                Console.WriteLine($"{i+1} {channels[i]}");
            }
            Console.WriteLine("");

            int randomChannel = random.Next(1, 20);
            randomChannel--;

            string currentСhannel = tv.СurrentСhannel(channels, ref randomChannel);
            Console.WriteLine($"Канал {randomChannel + 1} {currentСhannel}");

            string nextСhannel = tv.NextСhannel(channels, ref randomChannel);
            Console.WriteLine($"Канал {randomChannel + 1} {nextСhannel}");

            string backСhannel = tv.BackСhannel(channels, ref randomChannel);
            Console.WriteLine($"Канал {randomChannel + 1} {backСhannel}");
            Console.ReadKey();
        }
    }    
}
