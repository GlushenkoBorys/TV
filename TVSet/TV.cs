using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSet
{
    struct ChannelTV
    {
        internal string onOff;
        internal int numberChannel;
    }
    class TV 
    {
        Random random = new Random();
        //ChannelTV[] channelTV = new ChannelTV[100];
        ChannelTV[] channelTV;
        //int channel = 0;

        public TV(ChannelTV[] channelTV)
        {
            this.channelTV = channelTV;
        }
        public void Channels()
        {
            for (int i = 0; i < channelTV.Length; i++)
            {
                int randomNumber = random.Next(1, 100);

                if (randomNumber % 2 == 0)
                {
                    channelTV[i].onOff = "On";
                }
                else
                {
                    channelTV[i].onOff = "Off";
                }

                channelTV[i].numberChannel = i;
            }
        }
        //public void NextСhannel()
        //{
        //    channel++;
        //    Console.WriteLine($"Канал {channel} {channelTV[channel].onOff}");
        //    Console.WriteLine();
        //}
        //public void BackСhannel()
        //{
        //    channel--;
        //    Console.WriteLine($"Канал {channel} {channelTV[channel].onOff}");
        //    Console.WriteLine();
        //}
        //public void СurrentСhannel(int numberChannel)
        //{
        //    channel = numberChannel;
        //    Console.WriteLine($"Канал {channel} {channelTV[channel].onOff}");
        //    Console.WriteLine();
        //}
    }
}
