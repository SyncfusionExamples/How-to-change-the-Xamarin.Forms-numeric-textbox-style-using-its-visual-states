﻿using Syncfusion.SfNumericTextBox.XForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GettingStarted_NumericTextBox
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            numericTextBox.IsEnabled = (e.Value) ? true : false;
        }
    }
}
