using Model.DataAccessLayer;
using Model.POCO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controller
{
    public class PlaceController
    {
        private DALContext _dALContext;

        public PlaceController(DALContext dALContext)
        {
            _dALContext = dALContext;
        }

        /// <summary>
        /// Adauga place in baza de date
        /// </summary>
        /// <param name="place"></param>
        /// <returns>
        /// Lista de tip int corespunzatoare erorilor aparute la adaugare
        /// </returns>
        public List<int> AddPlace(Place place)
        {
            List<int> listOfError = Place.ListOfErrors(place, GetAllPlaces());

            if (listOfError.Count == 0)
            {
                _dALContext.PlaceDAL.AddPlace(place);
            }
          
            return listOfError;
        }

        /// <summary>
        /// Obtine toate placeurile din baza de date
        /// </summary>
        /// <returns>
        /// Lista de tip place
        /// </returns>
        public List<Place> GetAllPlaces()
        {
            return _dALContext.PlaceDAL.GetAllPlaces();
        }

        /// <summary>
        /// Scrie mesaj corespunzator erorilor aparute la introducerea unui place in fisier
        /// </summary>
        /// <param name="message"></param>
        public void FailedAddingPlace(String message)
        {
            File.WriteAllText("Logger.txt", message);
        }

        /// <summary>
        /// Scrie mesaj in fisier cu datele placeului introdus
        /// </summary>
        /// <param name="message"></param>
        public void AddHistoryPlaces(string message)
        {
            File.WriteAllText("History.txt", message);
        }

        public Place GetPlaceByContactId(int id)
        {
            return _dALContext.PlaceDAL.GetPlaceByContactId(id);
        }
    }
}
