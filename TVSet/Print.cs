using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSet
{
    static class Print
    {
        static int channel = 0;
        public static void NextСhannel(ChannelTV[] channelTV)
        {
            channel++;
            Console.WriteLine($"Канал {channel} {channelTV[channel].onOff}");
            Console.WriteLine();
        }
        public static void BackСhannel(ChannelTV[] channelTV)
        {
            channel--;
            Console.WriteLine($"Канал {channel} {channelTV[channel].onOff}");
            Console.WriteLine();
        }
        public static void СurrentСhannel(ChannelTV[] channelTV, int numberChannel)
        {
            channel = numberChannel;
            Console.WriteLine($"Канал {channel} {channelTV[channel].onOff}");
            Console.WriteLine();
        }
    }
}
