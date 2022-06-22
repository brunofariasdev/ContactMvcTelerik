using Contact.Data;
using Contact.Models;

namespace Contact.Repository
{
    public class ContactRepository : IContactRepository
    {
        private readonly DataContext _contactRepository;

        public ContactRepository(DataContext dataContext)
        {
            _contactRepository = dataContext;
            
        }
        public List<ContactModel> GetAll()
        {
            if(_contactRepository.Contacts != null)
            {

                return _contactRepository.Contacts.ToList();
            }
            else
            {
                return new List<ContactModel>();
            }
        }

        public ContactModel Add(ContactModel contact)
        {
            var newContact = new ContactModel { 
                Name = contact.Name,
                Phone = contact.Phone,
                Email = contact.Email,
            };
            _contactRepository.Add(newContact);
            _contactRepository.SaveChanges();
            return contact;
        }

        
    }
}
