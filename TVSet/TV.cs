using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSet
{
    class TV 
    {        
        int [] channelsTV;
        int channel = 0;
        int channelTV;

        public TV(int n)
        {
            channelsTV = new int[n];
        }
        public void Channels()
        {
            Random random = new Random();
            for (int i = 0; i < channelsTV.Length; i++)
            {
                int randomNumber = random.Next(1, 100);
                channelsTV[i] = randomNumber;               
            }
        }

        public void SetСhannel(string numberChannel)
        {

            int currentChannel = Int32.Parse(numberChannel);

            if (currentChannel >= 0 && currentChannel < 100)
            {
                channel = currentChannel;
                channelTV = channelsTV[channel];
            }
            else
            {
                Console.WriteLine("Вы ввели некорректный номер канала");
                Console.WriteLine();
            }
            Сhannel();
        }

        public void NextСhannel()
        {
            channel++;
            if(channel == 100)
            {
                channel = 0;
            }
            channelTV = channelsTV[channel];         
            Сhannel();
        }

        public void BackСhannel()
        {
            channel--;
            if (channel == -1)
            {
                channel = 99;
            }
            channelTV = channelsTV[channel];
            Сhannel();
        }

        public  void Сhannel()
        {
            Console.WriteLine($"Канал {channel} '{channelTV}'");
            Console.WriteLine();
        }
    }
}
