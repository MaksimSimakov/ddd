﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Stranici
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Juuli : ContentPage
    {
        public Juuli()
        {
            InitializeComponent();
            Grid grd = new Grid
            {
                RowDefinitions =
                {
                   new RowDefinition {Height=new GridLength(1,GridUnitType.Star)},
                   new RowDefinition { Height = new GridLength(3, GridUnitType.Star) },
                   new RowDefinition { Height = new GridLength(2, GridUnitType.Star) }


                },
                ColumnDefinitions =
                {
                    new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)}
                }
            };
            Label nimetus = new Label { Text = "Juuli Pilt", FontSize = 30 };
            Image img = new Image { Source = "juuli.jpg" };
            Label kirjeldus = new Label { Text = "Juuli on seitsemendas!!! \nCедьмой месяц года, расположенный между июнем и августом, в юлианском и григорианском календарях, пятый месяц староримского года, начинавшегося до реформы Цезаря с марта. Один из семи месяцев длиной в 31 день." };
            grd.Children.Add(nimetus, 0, 0);
            grd.Children.Add(img, 0, 1);
            grd.Children.Add(kirjeldus, 0, 2);
            Content = grd;
        }
    }
}