using StockTrader.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StockTrader.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ChartArea_ItemClick(object sender, Telerik.Windows.Controls.Charting.ChartItemClickEventArgs e)
        {
            TradeData td = e.DataPoint.DataItem as TradeData;
            MessageBox.Show(
                string.Format(
                    "Trading details for {0:d}:\n\nOpen\t: {1:c}\nHigh\t: {2:c}\nLow\t: {3:c}\nClose\t: {4:c}\n\nVolume\t: {5}",
                    td.FromDate, td.Open, td.High, td.Low, td.Close, td.Volume),
                td.Emission,
                MessageBoxButton.OK);
        }


    }
}

