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

        [Required]
        [StringLength(20)]
        public string Year { get; set; }

        [Required]
        [StringLength(255)]
        public string Rated { get; set; }

        [Column(TypeName = "date")]
        public DateTime Released { get; set; }

        [Required]
        [StringLength(255)]
        public string Runtime { get; set; }

        [Required]
        [StringLength(255)]
        public string Genre { get; set; }

        [Required]
        [StringLength(255)]
        public string Director { get; set; }

        [Required]
        [StringLength(500)]
        public string Writer { get; set; }

        [Required]
        [StringLength(500)]
        public string Actors { get; set; }

        [Required]
        [StringLength(1000)]
        public string Plot { get; set; }

        [Required]
        [StringLength(500)]
        public string Language { get; set; }

        [Required]
        [StringLength(100)]
        public string Country { get; set; }

        [Required]
        [StringLength(255)]
        public string Awards { get; set; }

        [Required]
        [StringLength(1000)]
        public string Poster { get; set; }

        [Required]
        [StringLength(20)]
        public string Metascore { get; set; }

        [Required]
        [StringLength(20)]
        public string ImdbRating { get; set; }

        [Required]
        [StringLength(50)]
        public string ImdbVotes { get; set; }

        [Required]
        [StringLength(50)]
        public string ImdbId { get; set; }

        [Required]
        [StringLength(50)]
        public string Type { get; set; }

        [Required]
        [StringLength(255)]
        public string Dvd { get; set; }

        [Required]
        [StringLength(255)]
        public string BoxOffice { get; set; }

        [Required]
        [StringLength(255)]
        public string Production { get; set; }

        public virtual ICollection<UserMovie> UserMovies { get; set; }

        public override int GetPrimaryKey()
        {
            return MovieId;
        }
    }
}
