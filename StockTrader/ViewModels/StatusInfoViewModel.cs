using Prism.Events;
using Prism.Mvvm;
using StockTrader.Common.Core;
using StockTrader.EventArgs;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrader.ViewModels
{
    public class StatusInfoViewModel: BaseViewModel
    {

        private ObservableCollection<string> _messages;
        public ObservableCollection<string> Messages
        {
            get { return _messages; }
            set { SetProperty(ref _messages, value); }
        }
        public StatusInfoViewModel()
        {

            Messages = new ObservableCollection<string>();
            this.EventAggregator.GetEvent<PubSubEvent<MyEventArgs>>().Subscribe(MessageReceived);
        }

        private void MessageReceived(MyEventArgs message)
        {
            Messages.Add(message.Message);
        }
    }
}
