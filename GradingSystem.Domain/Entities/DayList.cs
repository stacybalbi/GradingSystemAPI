using GradingSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem.Domain.Entities
{
    public class DayList : BaseEntity
    {
        public int StudentsId { get; set; }

        public Assistance assistance { get; set; }

        [ForeignKey("StudentsId")]
        public virtual Students Students { get; set; }
    }
}
