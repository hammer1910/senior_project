using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SeniorProject.Entities
{
    public class AccountRoleEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AccountRoleId { get; set; }

        public ICollection<AccountEntity> AccountId { get; set; } = new List<AccountEntity>();

        public ICollection<RoleEntity> RoleId { get; set; } = new List<RoleEntity>();
    }
}
