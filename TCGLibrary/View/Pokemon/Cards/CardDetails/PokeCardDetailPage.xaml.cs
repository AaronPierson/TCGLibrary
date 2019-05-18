using PKCDQuickType;
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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace TCGLibrary.View.Pokemon.Cards.CardDetails
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PokeCardDetailPage : Page
    {
        public PokeCardDetailPage()
        {
            this.InitializeComponent();
        }
        public Card _card = PokeCardDetailViewModel.Details;
        public Card card
        {
            get { return this._card; }
            set { }
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

            //var cardDetails = PokeCardDetailViewModel.Details;
            //imgName.Source = new BitmapImage(cardDetails.ImageUrlHiRes);

        }

    }
}
