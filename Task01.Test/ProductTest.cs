using ChannelEngine.Merchant.ApiClient.Model;
using Moq;
using System;
using System.Collections.Generic;
using Task.Service;
using Task01.Data.Repository;
using Task01.Interfaces;
using Xunit;

namespace Task01.Test
{
    public class ProductTest
    {
        public Mock<IMerchantProductRepository> SetUpMock()
        {
            var merchantProductRepositoryMock = new Mock<IMerchantProductRepository>();
            var products = new List<MerchantProductRequest> 
            {
                new MerchantProductRequest { MerchantProductNo = "1"} ,
                new MerchantProductRequest { MerchantProductNo = "2"} 
            };
            merchantProductRepositoryMock.Setup(ar => ar.GetProducts(It.IsAny<int>())).Returns(products);
            return merchantProductRepositoryMock;
        }

        [Fact]
        public void CountProducts()
        {
            var mock = SetUpMock();
            var productService = new ProductService(mock.Object);
            Assert.Equal(2, productService.Count());
        }
    }
}
