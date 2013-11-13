using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Vessel;

namespace LandingDemo
{
    public partial class HomePage : PhoneApplicationPage
    {
        public HomePage()
        {
            InitializeComponent();

            var v = VesselAB.whichVariation(VesselAB.whichTest());
            if (v == TestVariation.A)
            {
                VariantB.Visibility = Visibility.Collapsed;
                VariantA.Visibility = Visibility.Visible;
            }
            else
            {
                VariantA.Visibility = Visibility.Collapsed;
                VariantB.Visibility = Visibility.Visible;
            }
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            VesselAB.startSession("Sign up screen");
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            VesselAB.endSession("Sign up screen");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            VesselAB.checkPointVisited("signedUpWithFacebook");
        }

    }
}