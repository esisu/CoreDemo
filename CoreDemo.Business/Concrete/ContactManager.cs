using CoreDemo.Project.Business.Abstract;
using CoreDemo.Project.DataAccess.Abstract;
using CoreDemo.Project.Entities.Concrete;

namespace CoreDemo.Project.Business.Concrete
{
    public class ContactManager:IContactService
    {

        private readonly IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void ContactAdd(Contact contact)
        {
            _contactDal.Insert(contact);
        }

    }
}
