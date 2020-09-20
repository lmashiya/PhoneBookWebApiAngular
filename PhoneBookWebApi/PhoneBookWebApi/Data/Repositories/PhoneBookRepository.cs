using Microsoft.EntityFrameworkCore;
using PhoneBookWebApi.Data.Interfaces;
using System;

namespace PhoneBookWebApi.Models.Repositories
{
    public class PhoneBookRepository : CoreRepository<PhoneBookContact, PhoneBookContext>
    {
        private DbContext @object;

        public PhoneBookRepository(PhoneBookContext repoContext) : base(repoContext)
        {
            
        }

    }
}