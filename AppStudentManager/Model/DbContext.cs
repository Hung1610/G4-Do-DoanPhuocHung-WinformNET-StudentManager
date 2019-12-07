using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppG2.Model
{
    public class DbContext : System.Data.Entity.DbContext
    {
        public DbContext() : base("Data Source=.;Initial Catalog=DB_Student;User ID=sa;Password=123")
        {

        }

        public DbSet<Student> Students { get; set; }
    }
}
