using System.Collections.Generic;
using Task01.ApiConnection;
using Task01.Interfaces;

namespace Task01.Data.Repository
{
    public abstract class BaseRepository<TModel> : IBaseRepository<TModel> where TModel : class
    {
        public string BaseURL { get; set; }

        public BaseRepository(string baseURL)
        {
            this.BaseURL = baseURL;
        }

        public IList<TModel> Get<TModel>(string requestURL = null)
        {
            var result = new Requests(this.BaseURL).CallRequest<List<TModel>>(requestURL ?? string.Empty);
            return result.values;
        }
    }
}
