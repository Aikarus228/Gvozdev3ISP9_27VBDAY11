﻿using System;
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
    /// Логика взаимодействия для NoWindows.xaml
    /// </summary>
    public partial class NoWindows : Window
    {
        public NoWindows()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            YesWindow yesWindow = new YesWindow();
            yesWindow.Show();
        }
    }
}
