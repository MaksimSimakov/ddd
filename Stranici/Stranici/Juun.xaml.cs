using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Stranici
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Juun : ContentPage
    {
        public Juun()
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
            Label nimetus = new Label { Text = "Juuni Pilt", FontSize = 30 };
            Image img = new Image { Source = "juun.jpg" };
            Label kirjeldus = new Label { Text = "juun on kuues kuu!!! \nВ июне мы празднуем иванову ночь" };
            grd.Children.Add(nimetus, 0, 0);
            grd.Children.Add(img, 0, 1);
            grd.Children.Add(kirjeldus, 0, 2);
            Content = grd;
        }
    }
}