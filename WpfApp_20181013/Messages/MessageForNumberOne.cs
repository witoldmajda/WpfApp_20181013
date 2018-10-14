using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_20181013.Messages
{
    public class MessageForNumberOne
    {
        public MessageForNumberOne(string message)
        {
            Message = message;
        }

        public string Message { get; set; }
    }
}
