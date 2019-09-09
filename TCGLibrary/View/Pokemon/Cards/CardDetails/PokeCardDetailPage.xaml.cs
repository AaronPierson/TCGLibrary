using PKCDQuickType;
using PKSDQuickType;
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
        public Set _set = PKCardDetailViewModel.setDetails;
        public Card _card = PKCardDetailViewModel.Details;
        //public Card card
        //{
        //    get { return this._card; }
        //    set { }
        //}
        //public Set set
        //{
        //    get { return this._set; }
        //    set { }
        //}
        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            string setcode = _card.SetCode;
           var wtf = await PKCardDetailViewModel.GetCardSetAsync(setcode);
            imgCard.Source = new BitmapImage(_card.ImageUrlHiRes);
            imgSet.Source = new BitmapImage(wtf.LogoUrl);


            //grdSets.ItemsSource = PokeCardDetailViewModel.set;

        }

        private async void Grdset_ItemClick(object sender, ItemClickEventArgs e)
        {


            string Code = _card.SetCode;
            //string series = clickedItem.Series;


            await PKCardsViewModel.GetAllCardInSetAsync(Code);
            this.Frame.Navigate(typeof(PKCardsPage));
        }


    }
}
