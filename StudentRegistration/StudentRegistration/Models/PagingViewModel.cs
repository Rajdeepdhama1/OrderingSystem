using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRegistration.Models
{
    public class PagingViewModel
    {
        public IEnumerable<Data> users { get; set; }
        public int TotalPages { get; set; }
    }
}
