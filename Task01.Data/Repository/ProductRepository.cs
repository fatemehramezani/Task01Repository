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
    public class ProductRepository : BaseRepository<ChannelListedProductResponse>, IProductRepository
    {
        public ProductRepository(string baseURL) : base(baseURL) { }

        public IList<ChannelListedProductResponse> GetProducts(string status = "SOLD", int top = 0)
        {
            return base.Get<ChannelListedProductResponse>();
        }
    }
}
