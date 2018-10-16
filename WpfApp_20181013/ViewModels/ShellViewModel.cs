using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp_20181013.Messages;

namespace WpfApp_20181013.ViewModels
{
    public class ShellViewModel : PropertyChangedBase
    {
        private EventAggregator _ea;

        public ShellViewModel()
        {
            _ea = IoC.Get<EventAggregator>();
            _numberOne = new NumberOneViewModel(_ea);
            _numberTwo = new NumberTwoViewModel(_ea);
        }


        private NumberOneViewModel _numberOne;

        private NumberTwoViewModel _numberTwo;

        public NumberOneViewModel NumberOne
        {
            get { return _numberOne; }
            set { _numberOne = value; }
        }


        public NumberTwoViewModel NumberTwo
        {
            get { return _numberTwo; }
            set { _numberTwo = value; }
        }

        private string _currentMessage;
       

        public string CurrentMessage
        {
            get
            {
                return _currentMessage;
            }
            set
            {
                _currentMessage = value;
                NotifyOfPropertyChange(() => CurrentMessage);
                NotifyOfPropertyChange(() => CanMessageNumberOne);
                NotifyOfPropertyChange(() => CanMessageNumberTwo);
            }
        }

        public bool CanMessageNumberOne
        {
            get
            {
                return canSendMessage();
            }
        }

        private bool canSendMessage()
        {
            return !string.IsNullOrEmpty(CurrentMessage);
        }

        public void MessageNumberOne()
        {            
            _ea.PublishOnUIThread(new MessageForNumberOne(CurrentMessage));            
            CurrentMessage = string.Empty;
        }

        public void MessageNumberTwo()
        {            
            _ea.PublishOnUIThread(new MessageForNumberTwo(CurrentMessage));            
            CurrentMessage = string.Empty;
        }

        public bool CanMessageNumberTwo
        {
            get
            {
                return canSendMessage();
            }
        }
    }
}
