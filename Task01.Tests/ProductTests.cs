using System;
using System.Linq;
using Task01.Data.Repository;
using Xunit;

namespace Task01.Test
{
    public class ProductTests
    {
        private const string baseURL = @"https://api-dev.channelengine.net/api/v2/{0}?apikey=541b989ef78ccb1bad630ea5b85c6ebff9ca3322";
        private DataCollection dataCollection = new DataCollection(baseURL);

        [Fact]
        public void Top10Products()
        {
            var soldProducts = dataCollection.MerchantProductRepository.GetProducts(10);
            Assert.Equal(10,soldProducts.Count);
        }

        [Fact]
        public void UpdateName()
        {
            var merchantProductNo = "001201";
            var name = "T-shirt met lange mouw BASIC petrol";
            var result1 = dataCollection.MerchantProductRepository.UpdateProductName(merchantProductNo, $"UPDATED-{name}");
            Assert.True(result1);
            
            var result2 = dataCollection.MerchantProductRepository.UpdateProductName(merchantProductNo, $"{name}");
            Assert.True(result2);

            var soldProducts = dataCollection.MerchantProductRepository.GetProducts();
            var updateProduct = soldProducts.FirstOrDefault(c => c.MerchantProductNo == merchantProductNo);

            Assert.Equal(name, updateProduct.Name);
            Assert.Equal(merchantProductNo, updateProduct.MerchantProductNo);
        }
    }
}
