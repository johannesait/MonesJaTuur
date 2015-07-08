using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Login.Models
{
    public class DataRepository
    {
        public List<Contact> GetContacts()
        {
            DataContext context = new DataContext();
            return context.Contacts.ToList();
        }
    }
}