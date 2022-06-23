using Contact.Models;

namespace Contact.Repository
{
    public interface IContactRepository
    {
        void Add(ContactModel contact);
        void Delete(ContactModel contact);
        List<ContactModel> GetAll();
        void Update(ContactModel contact);

    }
}
