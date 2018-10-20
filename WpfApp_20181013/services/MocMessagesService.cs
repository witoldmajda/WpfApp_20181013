using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp_20181013.interfaces;

namespace WpfApp_20181013.services
{
    public class MocMessagesService : IMessagesService
    {
        private ObservableCollection<String> messages;

        public MocMessagesService()
        {
            messages = new List<String>
            {
                new String{Message = "1"};
            };
        }

        public ObservableCollection<object> Get()
        {
            throw new NotImplementedException();
        }
    }
}
