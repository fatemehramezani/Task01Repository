using System;
using System.Collections.Generic;

namespace Task01.Interfaces
{
    public interface IBaseRepository<TModel> where TModel: class
    {
        IList<TModel> Get<TModel>(string requestURL);
    }
}
