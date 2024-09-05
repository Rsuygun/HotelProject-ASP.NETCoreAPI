using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HotelProject.DataAccessLayer.Abstract
{
    public interface IContactDal : IGenericDal<Contact>
    {
        public int GetContactCount();
    }
}
