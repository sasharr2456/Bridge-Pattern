using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern
{
    public class Email : base_interface
    {
        public void Send(string message)
        {
            Console.WriteLine($"Отправка Email с сообщением: {message}");
        }
    }
}