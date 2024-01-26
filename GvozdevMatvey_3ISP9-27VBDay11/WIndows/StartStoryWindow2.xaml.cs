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
using System.Windows.Shapes;

namespace GvozdevMatvey_3ISP9_27VBDay11.WIndows
{

    public partial class StartStoryWindow2 : Window
    {
        public StartStoryWindow2()
        {
            InitializeComponent();
        }

        private void YesButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            YesWindow yesWindow = new YesWindow(); 
            yesWindow.Show();
        }

        private void NoButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            NoWindows noWindows = new NoWindows();
            noWindows.Show();
        }
    }
}
