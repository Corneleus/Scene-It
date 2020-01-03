using SceneIt.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SceneIt.DAL.Infrastructure
{
    public abstract class BaseEntity : IEntity
    {
        protected BaseEntity()
        {

        }

        public abstract int GetPrimaryKey();
    }
}
