using System;
using System.Linq;
using Task01.Data.Repository;
using Xunit;

namespace Task01.Test
{
    public class ProductTests
    {
        public const string baseURL = @"https://api-dev.channelengine.net/api/v2/{0}?apikey=541b989ef78ccb1bad630ea5b85c6ebff9ca3322";
       
        [Fact]
        public void UpdateName()
        {
            var dataCollection = new DataCollection(baseURL);
            var merchantProductNo = "001201";
            var name = "T-shirt met lange mouw BASIC petrol";
            dataCollection.MerchantProductRepository.UpdateProductName(merchantProductNo, $"UPDATED-{name}");
            dataCollection.MerchantProductRepository.UpdateProductName(merchantProductNo, $"{name}");

            var soldProducts = dataCollection.MerchantProductRepository.GetProducts();
            var updateProduct = soldProducts.FirstOrDefault(c => c.MerchantProductNo == merchantProductNo);

            Assert.Equal(name, updateProduct.Name);
            Assert.Equal(merchantProductNo, updateProduct.MerchantProductNo);
        }
    }
}
