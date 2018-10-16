using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_20181013.ViewModels
{
    public abstract class BaseViewModel : PropertyChangedBase
    {
        private ObservableCollection<String> _messagesRecieved;
        
        public ObservableCollection<String> MessagesRecieved
        {
            get
            {
                if(_messagesRecieved == null)
                {
                    _messagesRecieved = new ObservableCollection<string>();
                }
                return _messagesRecieved;                
            }
            
        }

        protected void AddMessage(string message)
        {
            MessagesRecieved.Add(message);
            NotifyOfPropertyChange(() => MessagesRecieved);
        }

    }
}
