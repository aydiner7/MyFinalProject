using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    // Generic Constraint / Generik Kısıtlama
    // Class : Referans tip kısıtlaması yapıldı.
    // IEntity : gelecek parametre ya IEntity ya da IEmtity implemente eden nesne olabilir.
    // new() : IEntity new lenemez. Bu yüzden onu implemente eden nesneler new lenebilir. 
        
    public interface IEntityRepository<T> where T:class , IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter=null);

        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}
