using Model.POCO;
using System;
using System.Collections.Generic;

namespace Model.POCO
{
    abstract public class Rule
    {
        public Boolean pass = true;

        /// <summary>
        /// Verifica respectarea unei reguli
        /// </summary>
        /// <param name="place"></param>
        /// <param name="listOfPlaces"></param>
        public abstract void PassTheRule(Place place, List<Place> listOfPlaces);
    }
}
