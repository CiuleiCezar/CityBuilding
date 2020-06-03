using Model.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Controllers
{
    public class ControllerContext
    {
        public DALContext dALContext = new DALContext();

        private DistrictController _districtController;
        private PlaceController _placeController;
        private PlaceTypeController _placeTypeController;
        private ContactController _contactController;
        private CityController _cityController;

        public CityController CityController
        {
            get
            {
                if(_cityController == null)
                {
                    _cityController = new CityController(dALContext);
                }
                return _cityController;
            }
        }
        public ContactController ContactController
        {
            get
            {
                if(_contactController == null)
                {
                    _contactController = new ContactController(dALContext);
                }
                return _contactController;
            }
        }

        public PlaceTypeController PlaceTypeController
        {
            get
            {
                if(_placeTypeController == null)
                {
                    _placeTypeController = new PlaceTypeController(dALContext);
                }
                return _placeTypeController;
            }
        }

        public DistrictController DistrictController
        {
            get
            {
                if(_districtController == null)
                {
                    _districtController = new DistrictController(dALContext);
                }
                return _districtController;
            }
        }

        public PlaceController PlaceController
        {
            get
            {
                if(_placeController == null)
                {
                    _placeController = new PlaceController(dALContext);
                }
                return _placeController;
            }
        }
    }
}
