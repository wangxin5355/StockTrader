using Prism.Commands;
using StockTrader.Common.Core;
using StockTrader.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Timers;

namespace StockTrader.ViewModels
{
    public class MainWindowViewModel: BaseViewModel
    {
        public MainWindowViewModel()
        {
            //初始化主题
            AppearanceManager.ChangeAppearance("Expression_Dark");
            ExecuteDelegateCommand = new DelegateCommand(Execute);
            this.Datas = TradeData.GetWeeklyData();
            //InitDatas();
            
        }

        public DelegateCommand ExecuteDelegateCommand { get; private set; }

        private ObservableCollection<TradeData> _datas;
        public ObservableCollection<TradeData> Datas
        {
            get { return _datas; }
            set { SetProperty(ref _datas, value); }
        }
        private static Timer t;
        //public void InitDatas()
        //{
        //    t = new Timer();
        //    t.Interval = 3000;
        //    t.Enabled = true;
        //    t.Elapsed += T_Elapsed;
        //    t.AutoReset = true;

        //}
        private void Execute()
        {
            x = x + 1;
            this.Datas.Add(new TradeData() { Emission = "MSFT", FromDate = new DateTime(2009, 9, x), Open = 24.6200, High = 24.8400, Low = 24.4100, Close = 24.8200, Volume = 52243880 });
        }

        public static int x = 8;
        private void T_Elapsed(object sender, ElapsedEventArgs e)
        {
           
            this.Datas.Add(new TradeData() { Emission = "MSFT", FromDate = new DateTime(2009, 9,x), Open = 24.6200, High = 24.8400, Low = 24.4100, Close = 24.8200, Volume = 52243880 });
            this.RaisePropertyChanged("Datas");
        }
    }
    public enum Themes
    {
        Office_Black,
        Office_Silver,
        Office_Blue,
        Summer,
        Vista,
        Windows8,
        Expression_Dark,
        Windows7,
        Office2013,
        Office2013_LightGray,
        Office2013_DarkGray,
        VisualStudio2013,
        VisualStudio2013_Blue,
        VisualStudio2013_Dark,
        Green_Dark,
        Green_Light,
        Office2016,
        Office2016Touch
    }
}
