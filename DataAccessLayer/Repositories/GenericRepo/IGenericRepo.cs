using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.GenericRepo
{
    public interface IGenericRepo<TEntity> where TEntity : class
    {
        List<TEntity> GetAll();
        TEntity? GetById(Guid id);
        void Add(TEntity Model);
        void Update(TEntity Model);
        void Delete(TEntity Model);
        void DeleteById(Guid id);
        void SaveChanges();

    }
}
