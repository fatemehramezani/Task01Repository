using ChannelEngine.Merchant.ApiClient.Model;
using System;
using System.Collections.Generic;

namespace Task01.Interfaces
{
    public interface IMerchantOrderRepository : IBaseRepository<MerchantOrderResponse>
    {
        IList<MerchantOrderResponse> GetOrdersByStatus(string status = "IN_PROGRESS");
    }
}
