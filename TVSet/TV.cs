using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSet
{
    class TV
    {
        public string NextСhannel(string[] channels, ref int channel)
        {
            channel++;
            return channels[channel];
        }
        public string BackСhannel(string[] channels, ref int channel)
        {
            channel--;
            return channels[channel];
        }
        public string СurrentСhannel(string[] channels, ref int channel)
        {
            return channels[channel];
        }
    }
}
