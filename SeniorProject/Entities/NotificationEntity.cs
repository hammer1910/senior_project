using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SeniorProject.Entities
{
    public class NotificationEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NotificationId { get; set; }

        [MaxLength(1000)]
        public string Message { get; set; }

        public DateTime CreatedDate { get; set; }

        public ICollection<AccountEntity> AccountId { get; set; } = new List<AccountEntity>();

        public ICollection<GroupEntity> GroupId { get; set; } = new List<GroupEntity>();
    }
}
