using Model.POCO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Database
{
    public class DatabaseContext: DbContext
    {
        
        public DatabaseContext(): base("CityDB")
        {
            System.Data.Entity.Database.SetInitializer(new DatabaseInitializer());
        }

        public DbSet<City> City { get; set; }
        public DbSet<Contact> Contact{ get; set; }
        public DbSet<District> District { get; set; }
        public DbSet<Layer> Layer { get; set; }
        public DbSet<LayerType> LayerType { get; set; }
        public DbSet<Photo> Photo { get; set; }
        public DbSet<Place> Place { get; set; }
        public DbSet<PlaceType> PlaceType { get; set; }
    }
}
