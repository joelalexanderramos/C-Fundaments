using System;
using System.Collections.Generic;

namespace Hello
{
    class Number
    {
        public List<int> GetNumber(int max, Action<int> msg)
        {
            List<int> ListNumber = new List<int>();

            for (int i = 1; i < max; i++)
            {

                msg?.Invoke(i);

                if (msg != null)
                {
                    //   msg(i);
                    msg.Invoke(i);

                }

                if (i % 2 == 0)
                {
                    ListNumber.Add(i);
                }
                System.Threading.Thread.Sleep(1000);
            }
            return ListNumber;
        }
    }
}