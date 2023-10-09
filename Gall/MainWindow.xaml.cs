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

namespace Gall
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

        private void Right_click(object sender, RoutedEventArgs e)
        {
            if (tab_control.Items.Count == tab_control.SelectedIndex + 1)
            {
                tab_control.SelectedIndex = 0;
            }
            else
                tab_control.SelectedIndex++;
        }
        private void Left_click(object sender, RoutedEventArgs e)
        {
            if (tab_control.SelectedIndex == 0)
            {
                tab_control.SelectedIndex = tab_control.Items.Count - 1;
            }
            else
                tab_control.SelectedIndex--;
        }
    }
}
