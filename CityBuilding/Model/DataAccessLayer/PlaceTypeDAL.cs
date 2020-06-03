using Model.Database;
using Model.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DataAccessLayer
{
    public class PlaceTypeDAL
    {

        private DatabaseContext _databaseContext;

        public PlaceTypeDAL(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        /// <summary>
        /// Obtine numele unui type dupa id-ul sau
        /// </summary>
        /// <param name="id"></param>
        /// <returns>
        /// Valoare string corespunzatoare numelui
        /// </returns>
        public string GetTypeNameById(int id)
        {
            return _databaseContext.PlaceType.Where(type => type.PlaceTypeId == id).FirstOrDefault<PlaceType>().placeType;
        }

       /// <summary>
       /// Obtine id-ul unui type dupa numele sau
       /// </summary>
       /// <param name="name"></param>
       /// <returns>
       /// Valoare int corespunzatoare id-ului
       /// </returns>
        public int GetTypeIdByName(string name)
        {
            return _databaseContext.PlaceType.Where(type => type.placeType == name).FirstOrDefault<PlaceType>().PlaceTypeId;
        }
    }
}
