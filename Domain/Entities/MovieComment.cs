using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class MovieComment : BaseEntity
    {
        public string By { get; set; }
        public string Context { get; set; }
        public int MovieId { get; set; }
        public Movie? Movie { get; set; }
    }
}
