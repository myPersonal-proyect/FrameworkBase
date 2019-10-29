using System.Collections.Generic;
using System.Threading.Tasks;

namespace FrameworkBase.Api.DataAccess.Contracts.Repositories
{
    public interface IRepository<T> where T : class
    {

        Task<T> Exist(int id);

        Task<IEnumerable<T>> GetAll();

        Task<T> Get(int id);

        Task DeleteAsync(int id);

        Task<T> UpdateAsync(int id, T element);

        Task<T> Add(T element);


    }
}
