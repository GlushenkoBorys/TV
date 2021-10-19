using System;

namespace TVSet
{
    abstract class TV 
    {        
        protected int [] channelsTV;
        protected int buttonNumber;

        public int ChannelTV
        {
            get
            {
                return this.channelsTV[buttonNumber];
            }
        }

        public int ButtonNumber
        {
            get
            {
                return this.buttonNumber;
            }
        }

        public TV(int n)
        {
            channelsTV = new int[n];
        }
        public virtual void Channels()
        {
            Random random = new Random();
            for (int i = 0; i < channelsTV.Length; i++)
            {
                int randomNumber = random.Next(1, 100);
                channelsTV[i] = randomNumber;               
            }
        }

        public int NumberChannelReturn()
        {
            return this.channelsTV[buttonNumber];
        }

    }
}
