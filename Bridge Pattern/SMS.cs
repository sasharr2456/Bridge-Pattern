using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern
{
    public class SMS : base_interface
    {
        public void Send(string message)
        {
            Console.WriteLine($"Отправка SMS с сообщением: {message}");
        }
    }
}