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
using TestAutoFac_SingleInstance.ViewModels;

namespace TestAutoFac_SingleInstance.Views
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView : Window
    {
        private IMainViewModel _mainViewModel;

        public MainView(IMainViewModel mainViewModel)
        {
            InitializeComponent();
            _mainViewModel = mainViewModel;
            this.DataContext = _mainViewModel;
        }
    }
}
