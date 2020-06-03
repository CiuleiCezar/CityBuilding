using System;
using Model.Database;
using Model.POCO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DataAccessLayer
{
    public class DistrictDAL
    {
        private DatabaseContext _databaseContext;

        public DistrictDAL(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        /// <summary>
        /// Adauga un district nou la baza de date
        /// </summary>
        /// <param name="district"></param>
        public void AddDistrict(District district)
        {
            _databaseContext.District.Add(new District() { Name = district.Name, CityId = district.CityId, Rating = district.Rating });
            _databaseContext.SaveChanges();        
        }

        /// <summary>
        /// Obtine toate districtele 
        /// </summary>
        /// <returns>
        /// Lista de tip District
        /// </returns>
        public List<District> GetAllDistricts()
        {
            return _databaseContext.District.ToList();
        }
        
        /// <summary>
        /// Obtine un district din baza de date
        /// </summary>
        /// <param name="name"></param> 
        /// <returns>
        /// Obiect de tip district corespunzator numelui
        /// </returns>
        public District GetDistrictByName(string name)
        {
            return _databaseContext.District.Where(district => district.Name == name).FirstOrDefault<District>();
        }

        /// <summary>
        /// Obtine toate placeurile din baza de date ale unui district
        /// </summary>
        /// <param name="district"></param>
        /// <returns>
        /// Lista de tip place
        /// </returns>
        public List<Place> GetAllPlacesFromDistrict(District district)
        {
            return _databaseContext.Place.Where(place => place.DistrictId == district.DistrictId).ToList();
        }
    }
}
