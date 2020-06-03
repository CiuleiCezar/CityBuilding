using Model.Database;
using Model.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DataAccessLayer
{
    public class ContactDAL
    {
        private DatabaseContext _databaseContext;

        public ContactDAL(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        /// <summary>
        /// Adaugare contact in baza de date
        /// </summary>
        /// <param name="contact"></param>
        public void AddContact(Contact contact)
        {
            _databaseContext.Contact.Add(new Contact() {Address = contact.Address, FacebookAddress = contact.FacebookAddress,
                                                           PhoneNumber = contact.PhoneNumber, Email = contact.Email});
            _databaseContext.SaveChanges();

        }

        /// <summary>
        /// Obtine un contact dupa id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>
        /// Obiect de tip contact
        /// </returns>
        public Contact GetContactById(int id)
        {
            return _databaseContext.Contact.Where(contact => contact.ContactId == id).FirstOrDefault<Contact>();
        }

        public Contact GetContactByAddress(string address)
        {
            return _databaseContext.Contact.Where(contact => contact.Address == address).FirstOrDefault<Contact>();
        }

        /// <summary>
        /// Obtine contactul cu cel mai mare id
        /// </summary>
        /// <returns>
        /// Id de tip int corespunzator contactului
        /// </returns>
        public int GetLastId()
        {
            return _databaseContext.Contact.OrderByDescending(contact => contact.ContactId).FirstOrDefault().ContactId;
        }
    }
}
