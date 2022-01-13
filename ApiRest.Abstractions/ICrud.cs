using System;
using System.Collections.Generic;

namespace ApiRest.Abstractions
{
    public interface ICrud<T>
    {
        T Save(T entity);       //actualiza o inserta según corresponda
        IList<T> GetAll();      //devuelve toda la lista de entidades
        T GetById(int id);      //devuelve una entidad específica
        void Delete(int id);    //elimina una entidad específica
    }
}
