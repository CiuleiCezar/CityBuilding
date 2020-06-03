using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.POCO
{
    public class PlaceDTO
    {
        public PlaceDTO(string districtName, string placeTypeName, int capacity, int score, int topLeftX, int topLeftY, 
            int bottomRightX, int bottomRightY, string address, string phoneNumber, string facebookAddress, string email)
        {
            DistrictName = districtName;
            PlaceTypeName = placeTypeName;
            Capacity = capacity;
            Score = score;
            TopLeftX = topLeftX;
            TopLeftY = topLeftY;
            BottomRightX = bottomRightX;
            BottomRightY = bottomRightY;
            Address = address;
            PhoneNumber = phoneNumber;
            FacebookAddress = facebookAddress;
            Email = email;
        }

        public string DistrictName { get; set; }
        public string PlaceTypeName { get; set; }
        public int Capacity { get; set; }
        public int Score { get; set; }
        public int TopLeftX { get; set; }
        public int TopLeftY { get; set; }
        public int BottomRightX { get; set; }
        public int BottomRightY { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string FacebookAddress { get; set; }
        public string Email { get; set; }
    }
}
