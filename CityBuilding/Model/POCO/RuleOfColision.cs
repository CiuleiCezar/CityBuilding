using System.Collections.Generic;

namespace Model.POCO
{
    public class RuleOfColision : Rule
    {
        /// <summary>
        /// Verifica daca argumentul place respecta regulile de constructie
        /// referitoare la coliziunea cu celelalte placeuri
        /// </summary>
        /// <param name="place"></param>
        /// <param name="listOfPlaces"></param>
        public override void PassTheRule(Place place, List<Place> listOfPlaces)
        {

            int x = place.TopLeftX;
            int y = place.TopLeftY;
            int height = place.BottomRightY - place.TopLeftY;
            int width = place.BottomRightX - place.TopLeftX;

            foreach(Place pl in listOfPlaces)
            {
                int x1 = pl.TopLeftX;
                int y1 = pl.TopLeftY;
                int height1 = pl.BottomRightY - pl.TopLeftY;
                int width1 = pl.BottomRightX - pl.TopLeftX;

                if(x < x1 + width1 && 
                   x + width > x1  &&
                   y < y1 + height1 &&
                   y + height > y1)
                {
                    pass = false;
                    return;
                }
            }
        }
    }
}