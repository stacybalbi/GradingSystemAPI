 using GradingSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem.Domain.Entities
{
    public class Score : BaseEntity
    {
        public int StudentsId { get; set; }

        public int SubjectId { get; set; }

        public int rating { get; set; }

        public Literals literals { get; set; }

        [ForeignKey("StudentsId")]
        public virtual Students Students { get; set; }

        [ForeignKey("SubjectId")]
        public virtual Subject Subject { get; set; }



    }
}
