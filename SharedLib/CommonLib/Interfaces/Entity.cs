using System;
using System.Collections.Generic;
using System.Text;

namespace CommonLib.Interfaces
{
    public class Entity : IEntity
    {
        public Guid Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public DateTime Deleted { get; set; }
    }
}
