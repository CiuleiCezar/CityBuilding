using Model.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Controllers
{
    public class PlaceTypeController
    {

        private DALContext _dALContext;

        public PlaceTypeController(DALContext dALContext)
        {
            _dALContext = dALContext;
        }

        /// <summary>
        /// Obtine numele unui type dupa un id oferit
        /// </summary>
        /// <param name="id"></param>
        /// <returns>
        /// Nume de tip string
        /// </returns>
        public string GetTypeNameById(int id)
        {
            return _dALContext.PlaceTypeDAL.GetTypeNameById(id);
        }

        /// <summary>
        /// Obtine id-ul unui type dupa un nume data
        /// </summary>
        /// <param name="name"></param>
        /// <returns>
        /// Id de tip int
        /// </returns>
        public int GetTypeIdByName(string name)
        {
            return _dALContext.PlaceTypeDAL.GetTypeIdByName(name);
        }
    }
}
