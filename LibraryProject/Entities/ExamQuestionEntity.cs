using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SeniorProject.Entities
{
    public class ExamQuestionEntity
    {
        [Key]
        public ICollection<QuestionEntity> QuestionId { get; set; } = new List<QuestionEntity>();

        [Key]
        public ICollection<ExamEntity> ExamId { get; set; } = new List<ExamEntity>();

        [MaxLength(10)]
        public string CorrectAnswer { get; set; }
    }
}

