namespace SceneIt.DAL
{
    using System.Data.Entity;
    using SceneIt.DAL.Entities;
    using SceneIt.DAL.Configurations;

    public partial class SceneItContext : DbContext
    {
        public SceneItContext()
            : base("name=SceneItContext")
        {
        }

        public virtual DbSet<Movies> Movies { get; set; }
        public virtual DbSet<UserMovies> UserMovies { get; set; }
        public virtual DbSet<User> Users { get; set; }

        public virtual void SetModified(object entitiy, object updatedEntity)
        {
            this.Entry(entitiy).CurrentValues.SetValues(updatedEntity);
            this.Entry(entitiy).State = EntityState.Modified;
        }

        public virtual void SetDeleted(object entitiy)
        {
            this.Entry(entitiy).State = EntityState.Deleted;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MoviesConfiguration());
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new UserMoviesConfiguration());
        }

    }
}
