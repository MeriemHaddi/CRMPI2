using DataCrmPi.Entites;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCrmPi
{
    public class CrmDB: DbContext
    {
        public DbSet<User> DBSetUser{ get; set; }
        public DbSet<Client> DBSetClient { get; set; }

        public DbSet<Admin> DbSetAdmin { get; set; }
        public DbSet<Employee> DBSetEmployee { get; set; }
        public DbSet<Post> DBSetPost { get; set; }
        public DbSet<Comment> DBSetComment { get; set; }
        public DbSet<Reaction> DBSetReaction { get; set; }
        public DbSet<Resources> DBSetResources { get; set; }
        public DbSet<TeleProspection> DBSetTeleProspection { get; set; }
        public DbSet<PointOfSale> DBSetPointOfSale { get; set; }

    }
}
