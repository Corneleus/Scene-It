namespace SceneIt.DAL.Entities
{
    using SceneIt.DAL.Infrastructure;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class User : BaseEntity
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

        public override int GetPrimaryKey()
        {
            return UserId;
        }
    }
}
