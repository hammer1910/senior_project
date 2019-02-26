using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SeniorProject.Entities
{
    public class AnswerUserEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AnswerUserId { get; set; }

        public ICollection<AccountEntity> AccountId { get; set; } = new List<AccountEntity>();

        public ICollection<ExamEntity> ExamId { get; set; } = new List<ExamEntity>();

        [MaxLength(10)]
        public string AnswerKey { get; set; }
    }
}
