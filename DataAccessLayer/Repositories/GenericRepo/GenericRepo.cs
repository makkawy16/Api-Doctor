using day2withDB.Data.Context.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.GenericRepo
{
    public class GenericRepo<TEntity> : IGenericRepo<TEntity> where TEntity : class
    {
        private readonly WebAppContext webAppContext;

        public GenericRepo(WebAppContext webAppContext)
        {
            this.webAppContext = webAppContext;
        }

        public List<TEntity> GetAll()
        {
            return webAppContext.Set<TEntity>().ToList();
        }

        public TEntity? GetById(Guid id)
        {
            return webAppContext.Set<TEntity>().Find(id);
        }

        public void Add(TEntity Model)
        {
            webAppContext.Set<TEntity>().Add(Model);
        }

        public void Delete(TEntity Model)
        {
            webAppContext.Set<TEntity>().Remove(Model);
        }

        public void DeleteById(Guid id)
        {
            var model = GetById(id);
            if (model is not null) 
                webAppContext.Set<TEntity>().Remove(model);
        }

   

        public void SaveChanges()
        {
            webAppContext.SaveChanges();
        }

        public void Update(TEntity Model)
        {
           // webAppContext.Set<TEntity>().Update(Model);
        }
    }
}
