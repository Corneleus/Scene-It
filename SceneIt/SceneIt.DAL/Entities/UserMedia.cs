namespace SceneIt.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserMedia")]
    public partial class UserMedia
    {
        public int UserMediaId { get; set; }

        public int UserId { get; set; }

        public int MediaId { get; set; }

        public bool Owned { get; set; }

        public bool HasSeen { get; set; }

        public bool? Recommend { get; set; }

        [StringLength(255)]
        public string RecommendNotes { get; set; }

        public virtual Media Media { get; set; }

        public virtual User User { get; set; }
    }
}
