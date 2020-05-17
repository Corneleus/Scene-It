using SceneIt.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SceneIt.DAL.Infrastructure
{
    public class DatabaseFactory : IDatabaseFactory
    {
        private bool isDisposed;
        private SceneItContext dataContext;

        public DatabaseFactory()
        {
            if(this.dataContext == null)
            {
                this.dataContext = new SceneItContext();
            }
        }

        public DatabaseFactory(SceneItContext dataContext)
        {
            this.dataContext = dataContext;
        }
                
        public SceneItContext Get()
        {
            return this.dataContext ?? (this.dataContext = new SceneItContext());
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void DisposeCore()
        {
            if (this.dataContext != null)
            {
                this.dataContext.Dispose();
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.isDisposed && disposing)
            {
                this.DisposeCore();
            }

            this.isDisposed = true;
        }
    }
}
