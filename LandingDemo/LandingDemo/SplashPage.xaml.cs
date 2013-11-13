using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using Vessel;
using System.Windows.Navigation;

namespace LandingDemo
{
    public partial class SplashPage : PhoneApplicationPage
    {
        // Constructor
        public SplashPage()
        {
            InitializeComponent();

            Loaded += SplashPage_Loaded;
        }

        void SplashPage_Loaded(object sender, RoutedEventArgs e)
        {
            VesselAB.setABListener(new MyCallbacks());
        }

        class MyCallbacks : ABListener
        {
            public void testLoading()
            {
            }

            public void testLoaded(String testName, TestVariation variation)
            {
                (Application.Current.RootVisual as PhoneApplicationFrame).Navigate(new Uri("/HomePage.xaml", UriKind.Relative));
            }

            public void testNotAvailable(TestVariation variation)
            {
                (Application.Current.RootVisual as PhoneApplicationFrame).Navigate(new Uri("/HomePage.xaml", UriKind.Relative));
            }
        };

    }
}