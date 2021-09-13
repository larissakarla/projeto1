using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projeto1.Areas.Seguranca.Models
{
    public class Papel : IdentityRole
    {
        public Papel() : base() { }
        public Papel(string name) : base(name) { }
    }
}