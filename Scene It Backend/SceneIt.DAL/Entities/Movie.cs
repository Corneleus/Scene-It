namespace SceneIt.DAL.Entities
{
    using SceneIt.DAL.Infrastructure;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    // todo , seperate the types of movies into its own entity and table in the database IE Movies, Episodic Movies, 
    public partial class Movie: BaseEntity
    {        
        public Movie()
        {
            UserMovies = new HashSet<UserMovie>();
        }

        [Key]
        public int MovieId { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        [StringLength(20)]
        public string Year { get; set; }

        [StringLength(255)]
        public string Rated { get; set; }

        [Column(TypeName = "date")]
        public DateTime Released { get; set; }

        [StringLength(255)]
        public string Runtime { get; set; }

        [StringLength(255)]
        public string Genre { get; set; }

        [StringLength(255)]
        public string Director { get; set; }

        [StringLength(500)]
        public string Writer { get; set; }

        [StringLength(500)]
        public string Actors { get; set; }

        [StringLength(1000)]
        public string Plot { get; set; }

        [StringLength(500)]
        public string Language { get; set; }

        [StringLength(100)]
        public string Country { get; set; }

        [StringLength(255)]
        public string Awards { get; set; }

        [StringLength(1000)]
        public string Poster { get; set; }

        [StringLength(20)]
        public string Metascore { get; set; }

        [StringLength(20)]
        public string ImdbRating { get; set; }

        [StringLength(50)]
        public string ImdbVotes { get; set; }

        [Required]
        [StringLength(50)]
        public string ImdbId { get; set; }

        [StringLength(50)]
        public string Type { get; set; }

        [StringLength(255)]
        public string Dvd { get; set; }

        [StringLength(255)]
        public string BoxOffice { get; set; }

        [StringLength(255)]
        public string Production { get; set; }

        public virtual ICollection<UserMovie> UserMovies { get; set; }

        public override int GetPrimaryKey()
        {
            return MovieId;
        }
    }
}
