using GradingSystem.Application.Generic.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem.Application.List.Dto
{
    public class ListDto : BaseDto
    {
        public string Name { get; set; }
        public int daylistId { get; set; }

        public DateTime Created { get; set; }
    }
}
