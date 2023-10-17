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

namespace CustomizedTitleBar {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void MinimizeButton_OnClick(object sender, RoutedEventArgs e) {
            this.WindowState = WindowState.Minimized;
        }


        private void MaximizeButton_OnClick(object sender, RoutedEventArgs e) {
            if (this.WindowState == WindowState.Maximized) this.WindowState = WindowState.Normal;
            else if (this.WindowState == WindowState.Normal) this.WindowState = WindowState.Maximized;
            else this.WindowState = WindowState.Normal;
        }


        private void CloseButton_OnClick(object sender, RoutedEventArgs e) {
            this.Close();
        }
    }
}