using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Model.Poco;
using Model.POCO;

namespace Model.POCO
{
    public class Place
    {
        [Key]
        public int PlaceId { get; set; }
        public int DistrictId { get; set; }
        public int PlaceTypeId { get; set; }
        public int ContactId { get; set; }
        public Contact Contact { get; set; }
        public int Capacity { get; set; }
        public int Score { get; set; }
        public int TopLeftX { get; set; }
        public int TopLeftY { get; set; }
        public int BottomRightX { get; set; }
        public int BottomRightY { get; set; }

        public Place(int districtId, int placeTypeId, int contactId, int capacity, int score,
             int topLeftX, int topLeftY, int bottomRightX, int bottomRightY)
        {
            DistrictId = districtId;
            PlaceTypeId = placeTypeId;
            ContactId = contactId;
            Capacity = capacity;
            Score = score;
            TopLeftX = topLeftX;
            TopLeftY = topLeftY;
            BottomRightX = bottomRightX;
            BottomRightY = bottomRightY;
        }
        /// <summary>
        /// Verifica daca un place verifica toate regulile
        /// De construire fata de celelalte placeuri
        /// </summary>
        /// <param name="place"></param>
        /// <param name="listOfPlaces"></param>
        /// <returns>
        /// Lista ce contine regulile ce nu au fost respectate
        /// </returns>
           public static List<int> ListOfErrors(Place place, List<Place> listOfPlaces)
        {
            List<int> listOfErors = new List<int>();

            RuleOfColision ruleOfColision = new RuleOfColision();
            RuleOfSize ruleOfSize = new RuleOfSize();

            List<Rule> rules = new List<Rule>();
            rules.Add(ruleOfColision);
            rules.Add(ruleOfSize);

            List<Boolean> listOfBooleans = new List<Boolean>();

            foreach (Rule rule in rules)
            {
                rule.PassTheRule(place, listOfPlaces);
                listOfBooleans.Add(rule.pass);
            }
            int numberOfError = 1;

            foreach(Boolean boolean in listOfBooleans)
            {
                if(boolean == false)
                {
                    listOfErors.Add((numberOfError));
                    numberOfError += 1;
                }
            }
           
            return listOfErors;
        }

        public Place()
        {
        }
    }
}
