﻿using System;

using Xamarin.Forms;

namespace CustomLogin
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();

            Navigation.PushModalAsync(new LoginPage());
        }
    }
}