using PKSetQuickType;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using TCGLibrary.View.Pokemon.Cards;
using TCGLibrary.ViewModels.Pokemon;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace TCGLibrary.View.Pokemon.Sets
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PKStandardPage : Page
    {
        public PKStandardPage()
        {
            this.InitializeComponent();
        }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            grdSets.ItemsSource = PKSetsViewModel.FilterStandardLegal(true);
        }

        private async void GrdSets_ItemClick(object sender, ItemClickEventArgs e)
        {
            var clickedItem = (Set)e.ClickedItem;
            string Code = clickedItem.Code;
            string series = clickedItem.Series;


            try
            {
                await PKCardsViewModel.GetAllCardInSetAsync(Code);
                this.Frame.Navigate(typeof(PKCardsPage), series);
            }
            catch (Exception ex)
            {
                var messageDialog = new MessageDialog("Try checking your internet connection. ");
                await messageDialog.ShowAsync();
            }
        }

    }
}
