﻿using System;
using Xamarin.Forms;

namespace SimpleStorageDateDemo
{
    public class App
    {
        public static Page GetMainPage()
        {    
            return new ContentPage { 
                Content = new Label {
                    Text = "Hello, Forms!",
                    VerticalOptions = LayoutOptions.CenterAndExpand,
                    HorizontalOptions = LayoutOptions.CenterAndExpand,
                },
            };
        }
    }
}

