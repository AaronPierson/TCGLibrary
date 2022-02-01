using System;
using TCGLibrary.View.MTG;
using TCGLibrary.View.PK;
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TCGLibrary
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class StartPage : Page
    {
        public StartPage()
        {
            this.InitializeComponent();
        }

        private async void Grdset_ItemClick(object sender, ItemClickEventArgs e)
        {
            var clickitem = (Windows.UI.Xaml.Controls.Image)e.ClickedItem;
            var messageDialog = new MessageDialog(clickitem.Name.ToString());

            if (clickitem.Name == "imgPK")
            {
                this.Frame.Navigate(typeof(PKCardsPage));
              //  await messageDialog.ShowAsync();
            }
            else if (clickitem.Name == "imgMagic")
            {
                this.Frame.Navigate(typeof(MTGPage));
                //await messageDialog.ShowAsync();
            }



        }
    }
}
