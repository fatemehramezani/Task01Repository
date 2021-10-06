using ChannelEngine.Merchant.ApiClient.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task01.ApiConnection;
using Task01.Interfaces;

namespace Task01.Data.Repository
{
    public class MerchantOrderRepository : BaseRepository<MerchantOrderResponse>, IMerchantOrderRepository
    {
        public MerchantOrderRepository(string baseURL) : base(baseURL) { }

        public IList<MerchantOrderResponse> GetOrdersByStatus(string status = "IN_PROGRESS")
        {                        
            return base.Get<MerchantOrderResponse>($"&statuses={status}");
        }
    }
}
