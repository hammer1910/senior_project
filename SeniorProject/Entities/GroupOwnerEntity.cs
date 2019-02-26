using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SeniorProject.Entities
{
    public class GroupOwnerEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GroupOwnerId { get; set; }

        public ICollection<AccountEntity> OwnerId { get; set; } = new List<AccountEntity>();

        public ICollection<GroupEntity> GroupId { get; set; } = new List<GroupEntity>();

    }
}
