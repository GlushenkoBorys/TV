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
            TV tv = new TV(100);
            tv.Channels();

            bool flagChannelOff = false;
            while (flagChannelOff == false)
            {
                Console.WriteLine("Введите номер канала от 0 до 99:");
                Console.WriteLine("Для пролистывания каналов вперед, нажмите: w");
                Console.WriteLine("Для пролистывания каналов назад, нажмите: s");
                Console.WriteLine("Для выключение телевизора, нажмите: off");
                Console.WriteLine();
                string way = Console.ReadLine();
                switch (way)
                {
                    case "w":
                        tv.NextСhannel();
                        break;

                    case "s":
                        tv.BackСhannel();
                        break;

                    case "off":
                        flagChannelOff = true;
                        break;

                    default:                       
                        tv.SetСhannel(way);                       
                        break;
                }               
            }
        }
    }    
}
