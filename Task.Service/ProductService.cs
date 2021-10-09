using System;
using Task01.Interfaces;

namespace Task.Service
{
    public class ProductService
    {
        private readonly IMerchantProductRepository _merchantProductRepository;

        public ProductService(IMerchantProductRepository merchantProductRepository)
        {
            _merchantProductRepository = merchantProductRepository;
        }

        public int Count()
        {
            return _merchantProductRepository.GetProducts().Count;
        }
    }
}
