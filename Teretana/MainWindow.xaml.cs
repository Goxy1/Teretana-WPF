﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace Teretana
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

        private void btnLogIn_Click(object sender, RoutedEventArgs e)
        {
            FormLogovanje formLogovanje = new FormLogovanje();
            formLogovanje.main = this;
            formLogovanje.Show();
        }

        private void btnSignUp_Click(object sender, RoutedEventArgs e)
        {
            FormKreiranjeNaloga formKreiranjeNaloga = new FormKreiranjeNaloga();
            formKreiranjeNaloga.main = this;
            formKreiranjeNaloga.Show();
        }
    }
}
