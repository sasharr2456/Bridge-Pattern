using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern
{
    public class TEXTMessage : Message
    {
        public TEXTMessage(base_interface value) : base(value) { }

        public override void Notify(string message)
        {
            _value.Send(message);
        }
    }
}