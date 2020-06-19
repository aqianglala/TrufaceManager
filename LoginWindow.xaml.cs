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
    /// LoginWindow.xaml 的交互逻辑
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            //if(TextBoxName.Text.Trim().Length == 0)
            //{
            //    MessageBox.Show("Name is empty");
            //    return;
            //}
            //if (PasswordBoxPassword.Password.Trim().Length == 0)
            //{
            //    MessageBox.Show("Password is empty");
            //    return;
            //}

            MainWindow window = new MainWindow();
            window.UserName = TextBoxName.Text;
            window.Show();
            Close();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
