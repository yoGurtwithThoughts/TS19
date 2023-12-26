using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace TS19
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
        public void ChangeThem(int theme)
        {
            ResourceDictionary themeDict = new ResourceDictionary();

            switch (theme)
            {
                case 1:
                    themeDict.Source = new Uri("pack://application:,,,/Theme/Theme1.xaml");
                    break;
                    case 2:
                    themeDict.Source = new Uri("pack://application:,,,/Theme/Theme2.xaml");
                    break;
                default:
                    return;

            }


            Application.Current.Resources.MergedDictionaries.Add(themeDict);
            ChangeThem(theme);

            ChangeThem(1);
            ChangeThem(2);




        }
        private void ToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            ChangeThem(2);
        }

        private void ToggleButton_Unchecked(object sender, RoutedEventArgs e)
        {
            ChangeThem(1);
        }
    }
}
