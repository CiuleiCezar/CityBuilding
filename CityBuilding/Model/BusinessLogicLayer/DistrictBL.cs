using Model.DataAccessLayer;
using Model.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.BusinessLogicLayer
{
    public class DistrictBL
    {
        private DistrictDAL _districtDAL;

        public DistrictBL(DistrictDAL districtDAL)
        {
            _districtDAL = districtDAL;
        }

        public float ComputeDistrictRating(District district)
        {
            float rating = 0.0F;
            List<Place> listOfPlaces = _districtDAL.GetAllPlacesFromDistrict(district);

            foreach (Place place in listOfPlaces)
            {
                rating += place.Score;
            }
            return rating / listOfPlaces.Count;
        }

    }
}
