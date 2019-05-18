using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using TCGLibrary.ViewModels.Pokemon;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TCGLibrary
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void NavRoot_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            switch (args.InvokedItem)
            {
                case "All Sets":
                    ContentFrame.Navigate(typeof(View.Pokemon.Sets.PKAllSetsPage));
                    break;

                case "Expanded Legal":
                    ContentFrame.Navigate(typeof(View.Pokemon.Sets.PKExpandedPage));
                    break;

                case "Standard Legal":
                    ContentFrame.Navigate(typeof(View.Pokemon.Sets.PKStandardPage));
                    break;


            }
        }

        private void NavRoot_Loading(FrameworkElement sender, object args)
        {

        }

        private async void Page_Loading(FrameworkElement sender, object args)
        {
            await SetsViewModel.GetAllCardSetsAsync();
            ContentFrame.Navigate(typeof(View.Pokemon.Sets.PKAllSetsPage));
          
        }

        private void NavRoot_BackRequested(NavigationView sender, NavigationViewBackRequestedEventArgs args)
        {
            
            // Navigate back
            if (ContentFrame.CanGoBack)
            {
                ContentFrame.GoBack();
            }
        }
    }
}
