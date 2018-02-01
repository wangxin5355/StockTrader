using Prism.Events;
using Prism.Mvvm;
using StockTrader.EventArgs;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrader.ViewModels
{
    public class StatusInfoViewModel: BindableBase
    {
        IEventAggregator _ea;
        private ObservableCollection<string> _messages;
        public ObservableCollection<string> Messages
        {
            get { return _messages; }
            set { SetProperty(ref _messages, value); }
        }
        public StatusInfoViewModel(IEventAggregator ea)
        {
            _ea = ea;
            Messages = new ObservableCollection<string>();
            _ea.GetEvent<PubSubEvent<MyEventArgs>>().Subscribe(MessageReceived);
        }

        private void MessageReceived(MyEventArgs message)
        {
            Messages.Add(message.Message);
        }
    }
}
