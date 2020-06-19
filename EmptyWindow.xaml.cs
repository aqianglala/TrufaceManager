using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace tf
{
    /// <summary>
    /// EmptyWindow.xaml 的交互逻辑
    /// </summary>
    public partial class EmptyWindow : Window
    {
        public string DilaogTitle
        {
            get;
            set;
        }
        public EmptyWindow()
        {
            InitializeComponent();
            this.Loaded += EmptyWindow_Loaded;
        }

        private void EmptyWindow_Loaded(object sender, RoutedEventArgs e)
        {
            TitleTextBlock.Text = DilaogTitle;
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
