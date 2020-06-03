using Model.DataAccessLayer;
using Model.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Controllers
{
    public class DistrictController
    {

        private DALContext _dALContext;

        public DistrictController(DALContext dALContext)
        {
            _dALContext = dALContext;
        }

        /// <summary>
        /// Calculeaza ratingul unui district oferit ca parametru
        /// </summary>
        /// <param name="name"></param>
        /// <returns>
        /// Variabila tip float
        /// </returns>
        public float ComputeDistrictRating(String name)
        {
            float rating = 0.0F;
            District district = _dALContext.DistrictDAL.GetDistrictByName(name);
            List<Place> listOfPlaces = _dALContext.DistrictDAL.GetAllPlacesFromDistrict(district);

            return District.ComputeDistrictRating(listOfPlaces);
        }

        /// <summary>
        /// Obtine toate districtele
        /// </summary>
        /// <returns>
        /// Lista de tip district
        /// </returns>
        public List<District> GetAllDistricts()
        {
            return _dALContext.DistrictDAL.GetAllDistricts();
        }

        /// <summary>
        /// Adauga district in baza de date
        /// </summary>
        /// <param name="district"></param>
        public void AddDistrict(District district)
        {
            _dALContext.DistrictDAL.AddDistrict(district);
        }

        public District GetDistrictIdByName(string name)
        {
            return _dALContext.DistrictDAL.GetDistrictByName(name);
        }
    }
}
