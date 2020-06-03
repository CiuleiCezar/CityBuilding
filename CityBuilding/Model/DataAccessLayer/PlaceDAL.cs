using Model.Database;
using Model.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DataAccessLayer
{
    public class PlaceDAL
    {
        private DatabaseContext _databaseContext;

        public PlaceDAL(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
      
        /// <summary>
        /// Adaugare place in baza de date
        /// </summary>
        /// <param name="place"></param>
        public void AddPlace(Place place)
        {
            _databaseContext.Place.Add(new Place() { DistrictId = place.DistrictId, PlaceTypeId = place.PlaceTypeId, 
                                                     ContactId = place.ContactId, Capacity = place.Capacity,
                                                     Score = place.Score, TopLeftX = place.TopLeftX, TopLeftY = place.TopLeftY,
                                                     BottomRightX = place.BottomRightX, BottomRightY = place.BottomRightY
                                                    });
            _databaseContext.SaveChanges();
        }

        /// <summary>
        /// Obtine toate placeurile din baza de date
        /// </summary>
        /// <returns>
        /// Lista de tip place
        /// </returns>
        /// 
        public List<Place> GetAllPlaces()
        {
            return _databaseContext.Place.ToList();
        }

        public Place GetPlaceByContactId(int id)
        {
            return _databaseContext.Place.Where(place => place.ContactId == id).FirstOrDefault<Place>();
        }
    }
}
