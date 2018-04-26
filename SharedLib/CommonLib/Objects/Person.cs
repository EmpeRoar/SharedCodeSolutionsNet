using CommonLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommonLib.Objects
{
    public class Person : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
