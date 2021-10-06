using ChannelEngine.Merchant.ApiClient.Model;
using System;
using System.Collections.Generic;

namespace Task01.Interfaces
{
    public interface IProductRepository : IBaseRepository<ChannelListedProductResponse>
    {
        IList<ChannelListedProductResponse> GetProducts(string status = "SOLD", int top = 0);
    }
}
