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
using System.Windows.Threading;

namespace tf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string UserName
        {
            get;
            set;
        }
        public MainWindow()
        {
            InitializeComponent();
            this.Height = (System.Windows.SystemParameters.PrimaryScreenHeight * 0.8);
            this.Width = (System.Windows.SystemParameters.PrimaryScreenWidth * 0.8);
            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            DispatcherTimer timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal,
                new EventHandler(ShowTime), this.Dispatcher);
            TextBlockName.Text = UserName;
        }

        private void ShowTime(object sender, EventArgs e)
        {
            dateText.Text = "Time: ";
            dateText.Text += DateTime.Now.ToString("HH:mm");
            dateText.Text += " | Date: ";
            dateText.Text += DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MenuItem item = (MenuItem)sender;
            showEmptyWindow(item);
        }

        private void showEmptyWindow(MenuItem item)
        {
            string title = item.Header.ToString();
            if (title.Contains("."))
            {
                title = title.Substring(0, title.IndexOf("."));
            }
            EmptyWindow window = new EmptyWindow();
            window.DilaogTitle = title;
            window.Show();
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            Window window = new AboutWindow();
            window.Show();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit?", "Truface Manager",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
            else
            {

            }
        }

        private void MinButton_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = System.Windows.WindowState.Minimized;
        }
    }
}
