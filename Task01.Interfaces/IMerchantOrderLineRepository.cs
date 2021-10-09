using ChannelEngine.Merchant.ApiClient.Model;
using System;
using System.Collections.Generic;

namespace Task01.Interfaces
{
    public interface IMerchantOrderLineRepository : IBaseRepository<MerchantOrderLineResponse>
    {
        IList<MerchantOrderLineResponse> GetOrderLinesByStatus(string status = "IN_PROGRESS");
    }
}
