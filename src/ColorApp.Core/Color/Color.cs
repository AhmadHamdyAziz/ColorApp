using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorApp.Color
{
    public class Color : AuditedEntity
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
