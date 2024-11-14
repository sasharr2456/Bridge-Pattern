using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern
{
    public class HTMLMessage : Message
    {
        public HTMLMessage(base_interface value) : base(value) { }

        public override void Notify(string message)
        {
            string htmlMessage = $"*HTML text* {message}";
            _value.Send(htmlMessage);
        }
    }
}