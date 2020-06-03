using Model.DataAccessLayer;
using Model.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Controllers
{
    public class ContactController
    {

        private DALContext _dALContext;

        public ContactController(DALContext dALContext)
        {
            _dALContext = dALContext;
        }

        /// <summary>
        /// Obtine ultimul id introdus in baza de date
        /// </summary>
        /// <returns>
        /// Id de tip int
        /// </returns>
        public int GetLastId()
        {
            return _dALContext.ContactDAL.GetLastId();
        }

        public Contact GetContactByAddress(string address)
        {
            return _dALContext.ContactDAL.GetContactByAddress(address);
        }
    }
}
