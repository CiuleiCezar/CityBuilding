using Model.Database;
using Model.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DataAccessLayer
{
    public class CityDAL
    {
        private DatabaseContext _databaseContext;
        public CityDAL(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        /// <summary>
        /// Adauga oras nou in baza de date
        /// </summary>
        /// <param name="city"></param>
        public void AddCity(City city)
        {
            using(DatabaseContext databaseContext = new DatabaseContext())
            {
                databaseContext.City.Add(new City() { Name = city.Name, Latitude = city.Latitude, Longitude = city.Longitude});
                databaseContext.SaveChanges();
            }
        }

        public City getCity(string name)
        {
            using(DatabaseContext databaseContext = new DatabaseContext())
            {
                return _databaseContext.City.Where(city => city.Name == name).FirstOrDefault<City>();
            }
        }
    }
}
