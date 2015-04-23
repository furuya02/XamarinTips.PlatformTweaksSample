using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace PlatformTweaksSample
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            MainPage = new MyPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }

    class MyPage : ContentPage {
        public MyPage() {

            /*
            //【Device.Stylesのサンプル】
            var layout = new StackLayout{
                Padding = new Thickness(0,Device.OnPlatform(20,0,0),0,0),
            };
            layout.Children.Add(new Label {
                Text = Device.Styles.BodyStyleKey, Style = Device.Styles.BodyStyle
            });
            layout.Children.Add(new Label {
                Text = Device.Styles.CaptionStyleKey, Style = Device.Styles.CaptionStyle
            });
            layout.Children.Add(new Label {
                Text = Device.Styles.ListItemDetailTextStyleKey, Style = Device.Styles.ListItemDetailTextStyle
            });
            layout.Children.Add(new Label {
                Text = Device.Styles.ListItemTextStyleKey, Style = Device.Styles.ListItemTextStyle
            });
            layout.Children.Add(new Label {
                Text = Device.Styles.SubtitleStyleKey, Style = Device.Styles.SubtitleStyle
            });
            layout.Children.Add(new Label {
                Text = Device.Styles.TitleStyleKey, Style = Device.Styles.TitleStyle
            });
            Content = layout;
            */

            /*
            //【Device.GetNamedSizeのサンプル】
            var layout = new StackLayout{
                Padding = new Thickness(20, Device.OnPlatform(20, 0, 0), 0, 0),
            };
            foreach (NamedSize n in Enum.GetValues(typeof(NamedSize))){
                var label = new Label();
                label.FontSize = Device.GetNamedSize(n, label);
                label.Text = string.Format("{0} ({1})", n, label.FontSize);
                layout.Children.Add(label);
            }
            Content = layout;
            */
            /*
            //【Device.Idiomのサンプル】
            Content = new Label {
                XAlign = TextAlignment.Center,
                YAlign = TextAlignment.Center,
                FontSize = 24,
                Text = Device.Idiom.ToString() 
            };
            */
            /*
            //【Device.OSのサンプル】
            var label = new Label{
                XAlign = TextAlignment.Center,
                YAlign = TextAlignment.Center,
                Text = Device.OS.ToString()
            };

            if (Device.OS == TargetPlatform.iOS) {
                BackgroundColor = Color.Black;
                label.TextColor = Color.White;
            }else if (Device.OS == TargetPlatform.Android){
                BackgroundColor = Color.White;
                label.TextColor = Color.Black;
            }
            Content = label;
            */
            /*
            //【Device.OnPlatformサンプル】
            Content = new StackLayout {
                Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0),
                Children = {new BoxView {
                    Color = Color.Red,
                    HeightRequest = 100
                }}
            };
            */
            //【Device.OpenUriサンプル】
            Content = new Button {
                Text = "Open",
                Command = new Command(() => Device.OpenUri(new Uri("http://xamarin.com/")))
            };

        }
    }
}
