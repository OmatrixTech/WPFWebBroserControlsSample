using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfAppWebBrowser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
            InitializeWebView();
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            //WpfWebbrowser.Navigate(new Uri("https://www.w3schools.com/"));
            //chromiumBrowser.Address = "https://www.w3schools.com/";
            //microsoftBrowser.Source = new Uri("https://www.w3schools.com/");
        }

        private async void InitializeWebView()
        {
            await microsoftBrowser.EnsureCoreWebView2Async(null);
            // Replace htmlString with your HTML content as a string.
            string htmlString = File.ReadAllText("SimpleHtmlPage.html");
            microsoftBrowser.CoreWebView2.NavigateToString(htmlString);
        }
    }
}
