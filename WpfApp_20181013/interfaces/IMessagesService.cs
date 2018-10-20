using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_20181013.interfaces
{
    public interface IMessagesService
    {
        ObservableCollection<String> Get();

    }
}
