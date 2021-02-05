using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{

    //Generic Constraint - Kısıt
    //class : referans tip olabilir.
    //IEntity : IEntity yada IEntity impemente eden bir nesne olmalı.
    //new() : new'lenebilir olmalı. Interface ler newlenemez o yüzden IEntity verilemez.
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {

        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
