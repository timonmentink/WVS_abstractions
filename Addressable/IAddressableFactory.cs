using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WVS.Abstractions.Addressable
{
    public interface IAddressableFactory
    {
        Task LoadContentCatalogAsync(bool neededOnStartup, string catalogPath,
            string providerSuffix);

        Task<T> LoadAssetAsync<T>(string resource);
    }
}
