using MtgApiManager.Lib.Core;
using MtgApiManager.Lib.Model;
using MtgApiManager.Lib.Service;
using System;
using System.Collections.Generic;
using TCGLibrary.ViewModel.MTG;
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace TCGLibrary.View.MTG
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MTGPage : Page
    {

        public MTGPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

            MTGViewModel mtg = new MTGViewModel();
            var set = mtg.getSetsAsync();
            grdSets.ItemsSource = set.Result.Value;

        }

        private void grdSets_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}
