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
            var result = base.Get<MerchantProductRequest>();
            return (top > 0 ? result.Take(top) : result).ToList();
        }

        //TODO: Fatemeh make it more general to supprot all columns
        public bool UpdateProductName(string merchantProductNo, string name)
        {
            if (string.IsNullOrEmpty(merchantProductNo))
            {
                throw new ArgumentException();
            }

            var patchContent = $"{{\"PropertiesToUpdate\": [\"name\"], \"MerchantProductRequestModels\": [{{\"MerchantProductNo\": \"{merchantProductNo}\",\"Name\": \"{name}\"}}]}}";
            var result = base.Patch<ProductCreationResult>(string.Empty, patchContent);
            return result.AcceptedCount == 1;
        }
    }
}
