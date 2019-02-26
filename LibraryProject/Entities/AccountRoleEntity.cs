using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SeniorProject.Entities
{
    public class AccountRoleEntity
    {
        [Key]
        public ICollection<AccountEntity> AccountId { get; set; } = new List<AccountEntity>();

        [Key]
        public ICollection<RoleEntity> RoleId { get; set; } = new List<RoleEntity>();
    }
}
