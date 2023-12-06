using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Interfaces
{
    public interface IBaseRepository<T, TEntity> where T: IEntity<TEntity>
    {
        T Get(TEntity id);
        void Create(T item);
        void Update(T item);
        void Delete(TEntity id);
        List<T> GetAll();
    }
}
