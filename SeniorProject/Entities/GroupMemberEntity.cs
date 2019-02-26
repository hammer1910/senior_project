using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SeniorProject.Entities
{
    public class GroupMemberEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GroupMemberId { get; set; }

        public ICollection<GroupEntity> GroupId { get; set; } = new List<GroupEntity>();

        public ICollection<AccountEntity> MemberId { get; set; } = new List<AccountEntity>();
    }
}
