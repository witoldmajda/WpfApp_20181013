using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp_20181013.Messages;

namespace WpfApp_20181013.ViewModels
{
    public class NumberOneViewModel : BaseViewModel, IHandle<MessageForNumberOne>
    {
        public NumberOneViewModel()
        {
            IoC.Get<IEventAggregator>().Subscribe(this);
        }

        public void Handle(MessageForNumberOne message)
        {
            AddMessage(message.Message);
        }
    }
}
