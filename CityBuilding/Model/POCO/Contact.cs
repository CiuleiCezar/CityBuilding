using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.POCO
{
    public class Contact
    {
        public Contact()
        {

        }

        public Contact(string address, string phoneNumber, string facebookAddress, string email)
        {
            Address = address;
            PhoneNumber = phoneNumber;
            FacebookAddress = facebookAddress;
            Email = email;
        }

        [Key]
        public int ContactId { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string FacebookAddress { get; set; }
        public string Email { get; set; }

    }
}
