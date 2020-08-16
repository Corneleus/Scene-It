namespace SceneIt.DAL.Entities
{
    using SceneIt.DAL.Infrastructure;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("UserMovies")]
    public partial class UserMovie : BaseEntity
    {
        public int UserMovieId { get; set; }

        public int UserId { get; set; }

        public int MovieId { get; set; }

        public bool Owned { get; set; }

        public bool HasSeen { get; set; }

        public bool? Recommend { get; set; }

        [StringLength(255)]
        public string RecommendNotes { get; set; }

        public virtual Movie Movie { get; set; }

        public virtual User User { get; set; }

        public override int GetPrimaryKey()
        {
            return UserMovieId;
        }
    }
}
