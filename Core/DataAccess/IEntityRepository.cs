using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //generic constraint 
    //-T kısmına sadece veritabanı nesneleri gelebilsin-
    //class: referans tip anlamında
    //IEnity: IEntity olabilir veya onu implemente eden bir nesne
   //new(): newlenebilir olmalı yani soyut sınıf işimizi görmez
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);  //filtre koymamızı sağlayan yapı
        T Get(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    
    }
}
