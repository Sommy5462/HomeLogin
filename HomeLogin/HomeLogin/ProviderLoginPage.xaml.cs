﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HomeLogin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProviderLoginPage : ContentPage
    {
        //we will refer providename from renderer page  
        public string ProviderName
        {
            get;
            set;
        }
        public ProviderLoginPage(string _providername)
        {
            InitializeComponent();
            ProviderName = _providername;
        }
    }
}