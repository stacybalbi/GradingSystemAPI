using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem.Domain.Entities
{
    public class List : BaseEntity
    {
        public string Name { get; set; }
        public int daylistId { get; set; }

        public DateTime Created { get; set; }
         
        [ForeignKey("daylistId")]
        public virtual DayList DayList { get; set; }
    }
}
