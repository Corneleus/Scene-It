using SceneIt.DAL.Interfaces;

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
