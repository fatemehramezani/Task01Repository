using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task01.Interfaces;

namespace Task01.Data.Repository
{
    public class DataCollection
    {        
        public string BaseURL { get; set; }

        public DataCollection(string baseURL)
        {
            BaseURL = baseURL;
        }

        public IMerchantOrderRepository MerchantOrderRepository
        {
            get
            {
                return new MerchantOrderRepository(BaseURL);
            }
        }

        public IProductRepository ProductRepository
        {
            get
            {
                return new ProductRepository(BaseURL);
            }
        }
    }
}
