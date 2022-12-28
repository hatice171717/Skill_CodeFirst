using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Skill_CodeFirst.Models.siniflar
{
    public class CONTEXT : DbContext
    {
        public DbSet<YETENEKLER> YETENEKLERS { get; set; }
    }
}