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
        private NumberOneViewModel _numberOne;

        public NumberOneViewModel NumberOne
        {
            get { return _numberOne; }
            set { _numberOne = value; }
        }

        private string _currentMessage;

        public ShellViewModel()
        {
            _numberOne = new NumberOneViewModel();
        }

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
            IoC.Get<IEventAggregator>().PublishOnUIThread(new MessageForNumberOne(CurrentMessage));
            CurrentMessage = string.Empty;
        }
    }
}
