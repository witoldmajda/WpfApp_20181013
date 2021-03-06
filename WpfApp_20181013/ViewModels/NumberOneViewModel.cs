﻿using Caliburn.Micro;
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

        private EventAggregator _ea;

        public NumberOneViewModel(EventAggregator _ea)
        {
            _ea.Subscribe(this);
             
        }
        
        public void Handle(MessageForNumberOne message)
        {
            AddMessage(message.Message);
        }
    }
}
