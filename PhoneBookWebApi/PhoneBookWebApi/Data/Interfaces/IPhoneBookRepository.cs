using System.Collections.Generic;
using System.Threading.Tasks;

namespace PhoneBookWebApi.Data.Interfaces
{
    public interface IPhoneBookRepository<T> where T : class, IEntity
    {
        Task<List<T>> GetAll();
        Task<T> Get(int id);
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(int id);
    }
}