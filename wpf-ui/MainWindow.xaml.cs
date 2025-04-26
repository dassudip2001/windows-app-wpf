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
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.Wpf;

namespace wpf_ui
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

        private async void InitWebView()
        {
            await webView.EnsureCoreWebView2Async(null);

            // If you're serving Angular app locally (like localhost:4200)
            //webView.Source = new Uri("http://localhost:4200");

            // OR if you want to load from local files after build
             webView.Source = new Uri("file:///C:/path-to-your-angular-build/index.html");
        }
    }
}
