namespace SceneIt.DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using SceneIt.DAL.Entities;
    using SceneIt.DAL.Configurations;

    public partial class SceneItContext : DbContext
    {
        public SceneItContext()
            : base("name=SceneItContext")
        {
        }

        public virtual DbSet<Media> Media { get; set; }
        public virtual DbSet<UserMedia> UserMedia { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MediaConfiguration());
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new UserMediaConfiguration());
        }

    }
}
