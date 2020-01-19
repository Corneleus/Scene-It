using SceneIt.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SceneIt.DAL.Infrastructure
{
    public class BaseRepository<TEntity> : IRepository<TEntity>
        where TEntity : BaseEntity
    {
        private readonly IDbSet<TEntity> dbSet;
        private readonly SceneItContext dataContext;

        protected BaseRepository(IDatabaseFactory databaseFactory)
        {
            this.DatabaseFactory = databaseFactory;
            this.dataContext = this.DatabaseFactory.Get();
            this.dbSet = this.dataContext.Set<TEntity>();    
        }

        protected IDatabaseFactory DatabaseFactory { get; private set; }

        public void Add(TEntity entity)
        {
            this.dbSet.Add(entity);
            this.dataContext.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            this.dbSet.Attach(entity);
            this.dataContext.SetDeleted(entity);
            this.dataContext.SaveChanges();
        }

        public void Delete(Expression<Func<TEntity, bool>> where)
        {
            IEnumerable<TEntity> entities = this.dbSet.Where<TEntity>(where).AsEnumerable();
            foreach (TEntity entity in entities)
            {
                this.dbSet.Attach(entity);
                this.dataContext.SetDeleted(entity);
            }
            this.dataContext.SaveChanges();
        }

        public TEntity Get(int id)
        {
            return this.dbSet.Find(id);
        }

        public TEntity Get(Expression<Func<TEntity, bool>> where)
        {
            return this.dbSet.Where(where).FirstOrDefault();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return this.dbSet;
        }

        public IEnumerable<TEntity> GetMany(Expression<Func<TEntity, bool>> where)
        {
            return this.dbSet.Where(where);
        }

        public void Update(TEntity entity)
        {
            var id = entity.GetPrimaryKey();
            var existingEntity = this.dbSet.Find(id);

            if (existingEntity == null)
            {
                this.dbSet.Add(entity);
            }
            else
            {
                this.dataContext.SetModified(existingEntity, entity);
            }

            this.dataContext.SaveChanges();
        }

        public void UpdateAll(List<TEntity> entities)
        {
            foreach (TEntity entity in entities)
            {
                var id = entity.GetPrimaryKey();
                var existingEntity = this.dbSet.Find(id);

                if (existingEntity == null)
                {
                    this.dbSet.Add(entity);
                }
                else
                {
                    this.dataContext.SetModified(existingEntity, entity);
                }
            }

            this.dataContext.SaveChanges();
        }
    }
}
