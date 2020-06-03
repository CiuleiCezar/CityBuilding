using Model.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DataAccessLayer
{
    public class DALContext
    {
        DatabaseContext databaseContext = new DatabaseContext();
        private ContactDAL _contactDAL;
        private DistrictDAL _districtDAL;
        private PlaceDAL _placeDAL;
        private CityDAL _cityDAL;
        private PlaceTypeDAL _placeTypeDAL;

        public DALContext()
        {

        }

        public CityDAL CityDAL
        {
            get
            {
                if(_cityDAL == null)
                {
                    _cityDAL = new CityDAL(databaseContext);
                }
                return _cityDAL;
            }
        }

        public ContactDAL ContactDAL
        {
            get
            {
                if(_contactDAL == null)
                {
                    _contactDAL = new ContactDAL(databaseContext);
                }
                return _contactDAL;
            }
        }

        public DistrictDAL DistrictDAL
        {
            get
            {
                if(_districtDAL == null)
                {
                    _districtDAL = new DistrictDAL(databaseContext);
                }
                return _districtDAL;
            }
        }

        public PlaceDAL PlaceDAL
        {
            get
            {
                if(_placeDAL == null)
                {
                    _placeDAL = new PlaceDAL(databaseContext);
                }
                return _placeDAL;
            }
        }

        public PlaceTypeDAL PlaceTypeDAL
        {
            get
            {
                if(_placeTypeDAL == null)
                {
                    _placeTypeDAL = new PlaceTypeDAL(databaseContext);
                }
                return _placeTypeDAL;
            }
        }
    }
}
