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
        ChannelTV[] channelTV;

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
    }
}
