using Prism.Events;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Windows.Controls;

namespace StockTrader.Common.Core
{
     public class BaseViewModel: BindableBase
    {
        protected IEventAggregator EventAggregator
        {
            get
            {
                return EventAggregatorHelper.EventAggregator;
            }
        }

        private bool isBusy;
        public bool IsBusy
        {
            get
            {
                return this.isBusy;
            }
            set
            {
                this.SetProperty(ref this.isBusy, value);
            }
        }

        public Action<bool?> Close { get; set; }

        public virtual void OnClosing(object sender, CancelEventArgs e) { }

        public virtual void OnClosing(object sender, WindowPreviewClosedEventArgs e) { }
        public class EventAggregatorHelper
        {
            private static readonly IEventAggregator eventAggregator = new EventAggregator();
            public static IEventAggregator EventAggregator
            {
                get { return eventAggregator; }
            }
        }
    }
}
