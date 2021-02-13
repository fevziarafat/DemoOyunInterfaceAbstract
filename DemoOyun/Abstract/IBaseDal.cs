using System;
using System.Collections.Generic;
using System.Text;

namespace DemoOyun.Abstract
{
    public interface IBaseDal<T>
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }

    
}
