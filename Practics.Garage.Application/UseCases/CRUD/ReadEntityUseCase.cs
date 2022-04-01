using Practics.Garage.Domain.Models.Base;
using System.Linq;

namespace Practics.Garage.Application.UseCases.CRUD
{
    public class ReadEntityResponse<TEntity> where TEntity : Entity
    {
        public IQueryable<TEntity> Entities { get; set; }
    }

    public class ReadEntityUseCase<TEntity> where TEntity : Entity
    {
    }
}
