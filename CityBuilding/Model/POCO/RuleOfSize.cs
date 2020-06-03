
using Model.POCO;
using System.Collections.Generic;

namespace Model.Poco
{
    public class RuleOfSize : Rule
    {   
        /// <summary>
        /// Verifica daca argumentul place respecta regulile de constructie
        /// referitoare la marime
        /// </summary>
        /// <param name="place"></param>
        /// <param name="listOfPlace"></param>
        public override void PassTheRule(Place place, List<Place> listOfPlace)
        {
            if ((place.BottomRightX - place.TopLeftX) > 45 || (place.BottomRightY - place.TopLeftY) > 45)
            {
                pass = false;
                return;
            }
        }
    }
}
