using Model.DataAccessLayer;
using Model.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Controllers
{
    public class CityController
    {
        private DALContext _dALContext;

        public CityController(DALContext dALContext)
        {
            _dALContext = dALContext;
        }

        public City GetCityByName(string name)
        {
            return _dALContext.CityDAL.getCity(name);
        }     
    }
}
