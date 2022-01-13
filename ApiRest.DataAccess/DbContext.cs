using ApiRest.Abstractions;
using System;
using System.Collections.Generic;

namespace ApiRest.DataAccess
{
    public class DbContext<T> : IDbContext<T>
    {
        IList<T> _data;

        public DbContext()
        {
            _data = new List<T>();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public T Save(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
