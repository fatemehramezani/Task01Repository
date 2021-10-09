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
    public class MerchantOrderLineRepository : BaseRepository<MerchantOrderLineResponse>, IMerchantOrderLineRepository
    {
        public MerchantOrderLineRepository(string baseURL) : base(baseURL) { }

        public IList<MerchantOrderLineResponse> GetOrderLinesByStatus(string status = "IN_PROGRESS")
        {
            return base.Get<MerchantOrderLineResponse>($"&statuses={status}");
        }
    }
}
