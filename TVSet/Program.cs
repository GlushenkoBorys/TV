using System;


namespace TVSet
{
    class Program
    {
        static void Main(string[] args)
        {
            SharpTV tv = new SharpTV(100);
            tv.Channels();

            IGettable igtv = tv;
            IGetButtonable igb = tv;

            tv.SetСhannel(2, 9);
            int count = 0;

            while (igtv.GetNextChannel())
            {
                int currentChannel = igtv.GetChannel();
                int currentButton = tv.NumberButtonReturn();
                Console.WriteLine($"Канал {currentChannel}");

                tv.Reset();
                while (tv.GetNextChannel())
                {
                    count++;
                    if (currentChannel == igtv.GetChannel())
                    {
                        Console.WriteLine($"Кнопка: {igb.NumberButtonReturn()}");
                    }
                }
                Console.WriteLine();
                igtv.SetNumberButton(currentButton);
            }

            Console.WriteLine(count);
            Console.ReadKey();
        }
    }    
}
