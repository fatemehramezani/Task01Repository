using Task01.Interfaces;

namespace Task01.Data.Repository
{
    public class DataCollection : IDataCollection
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
                return new MerchantOrderRepository(string.Format(BaseURL, "orders"));
            }
        }

        public IMerchantOrderLineRepository MerchantOrderLineRepository
        {
            get
            {
                return new MerchantOrderLineRepository(string.Format(BaseURL, "products"));
            }
        }

        public IMerchantProductRepository MerchantProductRepository
        {
            get
            {
                return new MerchantProductRepository(string.Format(BaseURL, "products"));
            }
        }
    }
}
