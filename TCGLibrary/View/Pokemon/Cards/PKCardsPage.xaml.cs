
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using TCGLibrary.View.Pokemon.Cards.CardDetails;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace TCGLibrary.View.Pokemon.Cards
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PKCardsPage : Page
    {
        public PKCardsPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
       
            grdSets.ItemsSource = PKCardsViewModel._allcardslst;
           
        }

        private async void GrdSets_ItemClick(object sender, ItemClickEventArgs e)
        {
            var clickitem = (PKCQuickType.Card)e.ClickedItem;
            string Id = clickitem.Id;
            await PKCardDetailViewModel.GetAllCardInSetAsync(Id);
            this.Frame.Navigate(typeof(PokeCardDetailPage));
        }
    }
}
