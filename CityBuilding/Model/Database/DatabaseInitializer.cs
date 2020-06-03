using Model.POCO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Database
{
    public class DatabaseInitializer: DropCreateDatabaseIfModelChanges<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            context.City.Add(new City() { Latitude = 45.45F, Longitude = 46.768F, Name = "Bicaz" });
            context.SaveChanges();
            context.District.Add(new District() { CityId = 1, Name = "Ciungi", Rating = 0.0F });
            context.SaveChanges();
            context.Contact.Add(new Contact() { Address = "bbb", PhoneNumber = "Aaa", FacebookAddress = "ccc" });
            context.Contact.Add(new Contact() { Address = "zzz", PhoneNumber = "Aaa", FacebookAddress = "ccc" });
            context.SaveChanges();    
            context.PlaceType.Add(new PlaceType() { placeType = "Factory" });
            context.SaveChanges();
            context.PlaceType.Add(new PlaceType() { placeType = "HouseBuilding" });
            context.SaveChanges();
            context.PlaceType.Add(new PlaceType() { placeType = "Forest" });
            context.SaveChanges();
            context.PlaceType.Add(new PlaceType() { placeType = "Hydro" });
            context.SaveChanges();
            context.PlaceType.Add(new PlaceType() { placeType = "Park" });
            context.SaveChanges();
            context.PlaceType.Add(new PlaceType() { placeType = "Hospital" });
            context.SaveChanges();
            context.Place.Add(new Place()
            {
                DistrictId = 1,
                PlaceTypeId = 1,
                ContactId = 1,
                Score = 3,
                TopLeftX = 20,
                TopLeftY = 20,
                BottomRightX = 40,
                BottomRightY = 40
            });
            context.SaveChanges();
            context.Place.Add(new Place()
            {
                DistrictId = 1,
                PlaceTypeId = 3,
                ContactId = 1,
                Score = 5,
                TopLeftX = 80,
                TopLeftY = 80,
                BottomRightX = 125,
                BottomRightY = 125
            });

            context.SaveChanges();
            context.Database.Initialize(force: false);
            base.Seed(context);
        }
    }
}   
