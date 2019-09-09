using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using TCGLibrary.View.Pokemon.Cards;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace TCGLibrary.View
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
        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {


            
            
            
           
           

        }

        private async void Grdset_ItemClick(object sender, ItemClickEventArgs e)
        {
            var clickitem = (Windows.UI.Xaml.Controls.Image)e.ClickedItem;
            
                 var messageDialog = new MessageDialog(clickitem.Name.ToString());
            
            if(clickitem.Name == "imgPK")
            {
                this.Frame.Navigate(typeof(PKCardsPage));
            }else if(clickitem.Name == "imgMagic")
            {
                await messageDialog.ShowAsync();
            }else if(clickitem.Name == "imgScrolls")
            {
                await messageDialog.ShowAsync(); 
            }


        }


    }
}
