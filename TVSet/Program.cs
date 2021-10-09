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
            ChannelTV[] channelTV = new ChannelTV[100];
            TV tv = new TV(channelTV);
            tv.Channels();

            bool flagChannelStart = false;
            while (flagChannelStart == false)
            {
                int channel;
                Console.WriteLine("Введите номер канала от 0 до 99:");
                Console.WriteLine("Для пролистывания каналов вперед, нажмите: w");
                Console.WriteLine("Для пролистывания каналов назад, нажмите: s");
                Console.WriteLine("Для выключение телевизора, нажмите: off");
                Console.WriteLine();
                string way = Console.ReadLine();
                switch (way)
                {
                    case "w":
                        try
                        {
                            Print.NextСhannel(channelTV);
                        }
                        catch
                        {
                            Print.СurrentСhannel(channelTV, 0);
                        }
                        break;
                    case "s":
                        try
                        {
                            Print.BackСhannel(channelTV);
                        }
                        catch
                        {
                            Print.СurrentСhannel(channelTV, 99);
                        }
                        break;
                    case "off":
                        flagChannelStart = true;
                        break;
                    default:
                        try
                        {
                            channel = Int32.Parse(way);
                        }
                        catch
                        {
                            channel = -1;
                        }
                        if (channel >= 0 && channel < 100)
                        {
                            Print.СurrentСhannel(channelTV, channel);
                        }
                        else
                        {
                            Console.WriteLine("Вы ввели не корректный номер канала");
                            Console.WriteLine();
                        }
                        break;
                }               
            }
        }
    }    
}
