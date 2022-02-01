using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using TCGLibrary.ViewModel.PK;
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

namespace TCGLibrary.View.PK.FrameSets
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PKAllSets : Page
    {
        public PKAllSets()
        {
            this.InitializeComponent();
        }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            PKViewModel pK = new PKViewModel();
            Dictionary<string, string> query = new Dictionary<string, string>()
            {
                { "name", "pika" },
                { "set", "Base" }
            };
            grdSets.ItemsSource = pK.AllSets(null);

        }

        private void grdSets_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}
