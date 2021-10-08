using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSet
{
    class TV
    {

        Random random = new Random();
        string[] channels = new string[20];
        int channel = 0;
        public void ChannelMeny()
        {
            for (int i = 0; i < channels.Length; i++)
            {
                int randomNumber = random.Next(1, 100);

                if (randomNumber % 2 == 0)
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

                Console.WriteLine($"{i + 1} {channels[i]}");
            }
            Console.WriteLine("");

        }
        public void NextСhannel()
        {
            channel++;
            Console.WriteLine($"Канал {channel + 1} {channels[channel]}");
        }
        public void BackСhannel()
        {
            channel--;
            Console.WriteLine($"Канал {channel + 1} {channels[channel]}");
        }
        public void СurrentСhannel(int numberChannel)
        {
            numberChannel--;
            channel = numberChannel;
            Console.WriteLine($"Канал {channel + 1} {channels[channel]}");
        }
    }
}
