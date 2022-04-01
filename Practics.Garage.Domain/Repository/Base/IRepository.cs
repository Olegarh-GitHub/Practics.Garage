using Practics.Garage.Domain.Models.Base;
using System.Linq;
using System.Threading.Tasks;

namespace Practics.Garage.Domain.Repository.Base
{
    public interface IRepository<TEntity> where TEntity : Entity
    {
        public Task<TEntity> Create(TEntity entity);

        public IQueryable<TEntity> Read();

        public Task<TEntity> Update(TEntity entity);

        public Task<bool> Delete(TEntity entity);
    }
}
