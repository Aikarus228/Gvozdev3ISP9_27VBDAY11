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
    /// <summary>
    /// Логика взаимодействия для WorldChoiceWindow.xaml
    /// </summary>
    public partial class WorldChoiceWindow : Window
    {
        public WorldChoiceWindow()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            ForestWindow forestWindow   = new ForestWindow();
            forestWindow.Show();
        }

        private void Sun_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            SunWindow sunWindow = new SunWindow();
            sunWindow.Show();
        }
    }
}
