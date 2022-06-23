using Contact.Data;
using Contact.Models;

namespace Contact.Repository
{
    public class ContactRepository : IContactRepository
    {
        private readonly DataContext _context;

        public ContactRepository(DataContext dataContext)
        {
            _context = dataContext;
            
        }
        public List<ContactModel> GetAll()
        {
            if(_context.Contacts != null)
            {

                return _context.Contacts.ToList();
            }
            else
            {
                return new List<ContactModel>();
            }
        }

        public ContactModel GetById(int Id)
        {
            var contact = _context.Contacts.FirstOrDefault(x => x.Id == Id);
            return contact == null ? null : contact;
        }
        public void Update(ContactModel contact)
        {
            var getContact = GetById(contact.Id);
            getContact.Id = contact.Id;
            getContact.Phone = contact.Phone;
            getContact.Email = contact.Email;
            getContact.Name = contact.Name;

            _context.Update(getContact);
            _context.SaveChanges();
        }
        public void Delete(ContactModel contact)
        {
            var get = GetById(contact.Id); 
            if(get != null)
            _context.Contacts.Remove(get);
            _context.SaveChanges();
        }

        public void Add(ContactModel contact)
        {
            var newContact = new ContactModel();
            newContact.Name = contact.Name;
            newContact.Email = contact.Email;
            newContact.Phone = contact.Phone;

            _context.Contacts.Add(newContact);
            _context.SaveChanges();
        }

    }
}
