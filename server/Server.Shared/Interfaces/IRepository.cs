using System.Linq;
using System.Threading.Tasks;

namespace Server.Inerfaces
{
    public interface IRepository<T> where T : IEntityMarker
    {
        Task Insert(T entity);
        Task Delete(T entity);
        Task<T> GetById(int id);
        Task<IQueryable<T>> GetAll();
    }

}