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
            int channel = 5;

            TV tv = new TV();
            tv.ChannelMeny();

            tv.СurrentСhannel(channel);
            
            tv.NextСhannel();

            tv.BackСhannel();

            Console.ReadKey();
        }
    }    
}
