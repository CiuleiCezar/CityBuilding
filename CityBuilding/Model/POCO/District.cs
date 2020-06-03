using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.POCO
{
    public class District
    {

        [Key]
        public int DistrictId { get; set; }
        public float Rating { get; set; }
        public string Name { get; set; }

        public int CityId { get; set; }
        public City City { get; set; }
        public ICollection<Place> Places { get; set; }

        public District()
        {

        }
        public District(float rating, string name, int cityId)
        {
            Rating = rating;
            Name = name;
            CityId = cityId;
        }

        /// <summary>
        /// Calculeaza ratingul unui distict
        /// </summary>
        /// <param name="listOfPlaces"></param>
        /// <returns>
        /// Variabila de tip float corespunzatoare ratingului
        /// </returns>
        public static float ComputeDistrictRating(List<Place> listOfPlaces)
        {
            float rating = 0.0F;

            foreach (Place place in listOfPlaces)
            {
                rating += place.Score;
            }
            return rating / listOfPlaces.Count;
        }
    }
}
