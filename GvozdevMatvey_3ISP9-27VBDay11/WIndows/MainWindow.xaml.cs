using GvozdevMatvey_3ISP9_27VBDay11.WIndows;
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

namespace GvozdevMatvey_3ISP9_27VBDay11
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            if(PasswordCheck.Password.Length >= 8)
            {
                this.Hide();
                StartStoryWindow startStoryWindow = new StartStoryWindow();
                startStoryWindow.Show();
            }
            else
            {
                MessageBox.Show("Пароль слишком короткий!");
            }
        }
    }
}
