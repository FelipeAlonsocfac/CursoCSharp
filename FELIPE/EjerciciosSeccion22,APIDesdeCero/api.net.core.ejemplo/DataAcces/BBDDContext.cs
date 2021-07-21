using api.net.core.ejemplo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.net.core.ejemplo.DataAcces
{
    public class BBDDContext : DbContext , IBBDDContext
    {
        public BBDDContext(DbContextOptions<BBDDContext> options):base(options)
        {

        }
        public DbSet<ModelItem> ModelItem { get; set; }

        public EntityEntry update(object entity)
        {
            throw new NotImplementedException();
        }
    }
}
