using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //generic constraint(generic kısıtlama-sadece veritabanıclassları kullanılabilsin generic olarak diye..
    //class:referans tip olması gerektiğini gösteriyor
    //IEntity veya IEntity implemente eden bir nesne olabilir
    //new():new lenebilir olmalı,Ientity yi dışarda bırakmak için kullandık.Çünkü
    //interfaceler new lenemez.
    public interface IEntityRepository<T>where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>>filter=null);
        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

         
    }
}
