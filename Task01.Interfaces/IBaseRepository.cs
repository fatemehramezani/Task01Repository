using System;
using System.Collections.Generic;

namespace Task01.Interfaces
{
    public interface IBaseRepository<TModel> where TModel: class
    {
        IList<TModel> Get<TModel>(string requestURL = null, string urlParameter = null);

        TModel Patch<TModel>(string requestURL, string patchData);
    }
}
