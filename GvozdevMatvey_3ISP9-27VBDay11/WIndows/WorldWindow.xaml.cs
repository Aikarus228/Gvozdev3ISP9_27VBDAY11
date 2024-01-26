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
    /// Логика взаимодействия для WorldWindow.xaml
    /// </summary>
    public partial class WorldWindow : Window
    {
        public WorldWindow()
        {
            InitializeComponent();
        }
        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            WorldWindow1 worldWindow = new WorldWindow1();
            worldWindow.Show();
        }
    }
}
