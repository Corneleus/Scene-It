namespace SceneIt.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {        
        public User()
        {
            UserMedia = new HashSet<UserMedia>();
        }
        
        public int UserId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
                
        public virtual ICollection<UserMedia> UserMedia { get; set; }
    }
}
