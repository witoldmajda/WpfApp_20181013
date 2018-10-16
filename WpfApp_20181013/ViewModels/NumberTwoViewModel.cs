using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp_20181013.Messages;

namespace WpfApp_20181013.ViewModels
{
    public class NumberTwoViewModel : BaseViewModel, IHandle<MessageForNumberTwo>
    {
        private EventAggregator _ea;

        public NumberTwoViewModel(EventAggregator _ea)
        {
            _ea.Subscribe(this);
        }
        
        public void Handle(MessageForNumberTwo message)
        {
            AddMessage(message.Message);
        }
    }
}
