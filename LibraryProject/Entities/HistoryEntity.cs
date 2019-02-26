using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SeniorProject.Entities
{
    public class HistoryEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int HistoryId { get; set; }

        public string StartTime { get; set; }

        public string EndTime { get; set; }

        public ICollection<AccountEntity> AccountId { get; set; } = new List<AccountEntity>();

        public ICollection<GroupEntity> GroupId { get; set; } = new List<GroupEntity>();

        public ICollection<ExamEntity> ExamId { get; set; } = new List<ExamEntity>();
    }
}
