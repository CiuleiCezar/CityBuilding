using Controller.Controllers;
using Model.DataAccessLayer;
using Model.POCO;
using System;
using System.Collections.Generic;

namespace Controller
{
    class Program
    {
        static void Main(string[] args)
        {
            DALContext dALContext = new DALContext();

            PlaceController placeController = new PlaceController(dALContext);
            DistrictController districtController = new DistrictController(dALContext);

            placeController.AddPlace(new Place()
            {
                DistrictId = 1,
                PlaceTypeId = 1,
                ContactId = 1,
                Score = 3,
                TopLeftX = 20,
                TopLeftY = 20,
                BottomRightX = 70,
                BottomRightY = 70
            });

     /*       List<Rule> rules = new List<Rule>();
            Rule rule1 = new RuleOfSize();
            rules.Add(rule1);
            Place place = new Place();
            List<Boolean> listOfBooleans = new List<Boolean>();

            foreach (Rule rule in rules)
            {
                rule.PassTheRule(place);
                listOfBooleans.Add(rule.pass);
            }*/

            Console.WriteLine(districtController.ComputeDistrictRating("Ciungi"));

            Console.ReadKey();

        }
    }
}
