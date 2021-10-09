using ChannelEngine.Merchant.ApiClient.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using Task01.Interfaces;

namespace Task01.Data.Repository
{
    public class MerchantProductRepository : BaseRepository<MerchantProductResponse>, IMerchantProductRepository
    {
        public MerchantProductRepository(string baseURL) : base(baseURL) { }

        public IList<MerchantProductRequest> GetProducts(int top = 0)
        {
            return base.Get<MerchantProductRequest>().Take(top).ToList();
        }

        //TODO: Fatemeh make it more general to supprot all columns
        public bool UpdateProductName(string merchantProductNo, string name)
        {
            if (string.IsNullOrEmpty(merchantProductNo))
            {
                throw new ArgumentException();
            }

            var patchContent = $"{{\"PropertiesToUpdate\": [\"name\"], \"MerchantProductRequestModels\": [{{\"MerchantProductNo\": \"{merchantProductNo}\",\"Name\": \"{name}\"}}]}}";
            return base.Patch(string.Empty, patchContent);
        }
    }
}
