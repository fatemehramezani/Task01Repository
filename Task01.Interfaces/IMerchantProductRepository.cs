using ChannelEngine.Merchant.ApiClient.Model;
using System;
using System.Collections.Generic;

namespace Task01.Interfaces
{
    public interface IMerchantProductRepository : IBaseRepository<MerchantProductRequest>
    {
        IList<MerchantProductRequest> GetProducts(int top = 0);

        bool UpdateProductName(string merchantProductNo, string name);
    }
}
