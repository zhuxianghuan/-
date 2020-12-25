﻿using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace MYTEST
{
    /// <summary>
    /// Batching_SBT.xaml 的交互逻辑
    /// </summary>
    public partial class SiloProductLine : UserControl
    {
        List<TagNodeHandle> _valueChangedList;

        public SiloProductLine()
        {
            InitializeComponent();
        }

        private void HMI_Loaded(object sender, RoutedEventArgs e)
        {
            lock (this)
            {
                _valueChangedList = cvs1.BindingToServer(App.Server);
            }
        }

        private void HMI_Unloaded(object sender, RoutedEventArgs e)
        {
            lock (this)
            {
                App.Server.RemoveHandles(_valueChangedList);
            }
        }
    }
}
