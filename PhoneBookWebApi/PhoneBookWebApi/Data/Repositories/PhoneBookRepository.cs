namespace PhoneBookWebApi.Models.Repositories
{
    public class PhoneBookRepository : CoreRepository<PhoneBookContact, PhoneBookContext>
    {
        public PhoneBookRepository(PhoneBookContext context) : base(context)
        {

        }

    }
}