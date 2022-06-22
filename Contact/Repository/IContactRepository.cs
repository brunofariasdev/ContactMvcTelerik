using Contact.Models;

namespace Contact.Repository
{
    public interface IContactRepository
    {
        ContactModel Add(ContactModel contact);

        List<ContactModel> GetAll();

        //ContactModel Get(int id);
    }
}
