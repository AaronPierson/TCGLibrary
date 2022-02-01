using MtgApiManager.Lib.Core;
using MtgApiManager.Lib.Model;
using MtgApiManager.Lib.Service;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TCGLibrary.ViewModel.MTG
{
    public class MTGViewModel
    {
        IMtgServiceProvider serviceProvider = new MtgServiceProvider();

        public async Task<IOperationResult<List<ISet>>> getSetsAsync()
        {
            ISetService service = serviceProvider.GetSetService();
            var result = await service.AllAsync();
            if (result.IsSuccess)
            {
                return result;
                //var messageDialog = new MessageDialog(value[0].ImageUrl.ToString());
            }
            return null;

        }
    }
}
