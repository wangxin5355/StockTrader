using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Telerik.Windows.Controls;
using static Telerik.Windows.Controls.FluentPalette;

namespace StockTrader.Common.Core
{
    public static class AppearanceManager
    {
        private static readonly string telerikThemePrefix = "/Telerik.Windows.Themes.";
        private static readonly string telerikThemeAssemblyFolder = ";component/Themes/";
        private static readonly string office2013Theme = "Office2013";
        private static readonly string visualStudio2013Theme = "VisualStudio2013";
        private static readonly string greenTheme = "Green";
        public static void ChangeAppearance(string theme)
        {
            string themeAssembly = GetThemeAssemblyName(theme.ToString());
            SetTheme(themeAssembly);
        }

        private static string GetThemeAssemblyName(string theme)
        {
            if (theme.Contains(office2013Theme))
            {
                return office2013Theme;
            }
            else if (theme.Contains(visualStudio2013Theme))
            {
                return visualStudio2013Theme;
            }
            if (theme.Contains(greenTheme))
            {
                return greenTheme;
            }
            else
            {
                return theme;
            }
        }

        private static void SetTheme(string theme)
        {
            Application.Current.Resources.MergedDictionaries.Clear();

            Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
            {
                Source = new Uri(string.Concat(telerikThemePrefix, theme, telerikThemeAssemblyFolder, "System.Windows.xaml"), UriKind.RelativeOrAbsolute)
            });
            Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
            {
                Source = new Uri(string.Concat(telerikThemePrefix, theme, telerikThemeAssemblyFolder, "Telerik.Windows.Controls.xaml"), UriKind.RelativeOrAbsolute)
            });
            Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
            {
                Source = new Uri(string.Concat(telerikThemePrefix, theme, telerikThemeAssemblyFolder, "Telerik.Windows.Controls.Data.xaml"), UriKind.RelativeOrAbsolute)
            });
            Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
            {
                Source = new Uri(string.Concat(telerikThemePrefix, theme, telerikThemeAssemblyFolder, "Telerik.Windows.Controls.Input.xaml"), UriKind.RelativeOrAbsolute)
            });
            Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
            {
                Source = new Uri(string.Concat(telerikThemePrefix, theme, telerikThemeAssemblyFolder, "Telerik.Windows.Controls.Navigation.xaml"), UriKind.RelativeOrAbsolute)
            });
            Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
            {
                Source = new Uri(string.Concat(telerikThemePrefix, theme, telerikThemeAssemblyFolder, "Telerik.Windows.Controls.ScheduleView.xaml"), UriKind.RelativeOrAbsolute)
            });
            Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
            {
                Source = new Uri(string.Concat(telerikThemePrefix, theme, telerikThemeAssemblyFolder, "Telerik.Windows.Controls.GridView.xaml"), UriKind.RelativeOrAbsolute)
            });
            Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
            {
                Source = new Uri(string.Concat(telerikThemePrefix, theme, telerikThemeAssemblyFolder, "Telerik.Windows.Controls.DataVisualization.xaml"), UriKind.RelativeOrAbsolute)
            });
            Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
            {
                Source = new Uri(string.Concat(telerikThemePrefix, theme, telerikThemeAssemblyFolder, "Telerik.Windows.Controls.Chart.xaml"), UriKind.RelativeOrAbsolute)
            });
           
        }

    }
}
