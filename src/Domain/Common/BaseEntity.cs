using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common
{
    public class BaseEntity
    {
        public DateTimeOffset Created { get; set; }

        public DateTimeOffset LastModified { get; set; }
    }
}
