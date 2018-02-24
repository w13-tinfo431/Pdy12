using ContosoUniversity.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ContosoUniversity.DAL
{
    public class BloggingContext : DbContext
    {
        public BloggingContext()
        {
            this.Configuration.ProxyCreationEnabled = false;
        }
    }
}