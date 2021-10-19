using System;

namespace TVSet
{
    class SharpTV : TV, IGettable, IGetButtonable
    {
        int count = 0;

        public SharpTV(int n) :base(n)
        {

        }
        public void Reset()
        {
            count = 0;
        }
      
        public bool GetNextChannel()
        {
            if(count == this.channelsTV.Length -1)
            {
                return false;
            }
            count++;
            return true;
        }

        public int GetChannel()
        {
            return this.channelsTV[count];
        }

        public void SetСhannel(int button, int channel)
        {
            this.channelsTV[button] = channel;          
        }

        public int NumberButtonReturn()
        {
            buttonNumber = count;
            return buttonNumber;
        }

        public bool GetNextButton()
        {
            if (count == this.channelsTV.Length - 1)
            {
                return false;
            }
            count++;
            return true;
        }

        public void SetNumberButton(int currentButton)
        {
            count = currentButton;
        }
    }
}
