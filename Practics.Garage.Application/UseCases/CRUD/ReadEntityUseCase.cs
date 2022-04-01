using Practics.Garage.Domain.Models.Base;
using Practics.Garage.Domain.Repository.Base;
using System.Linq;

namespace Practics.Garage.Application.UseCases.CRUD
{
    public class ReadEntityResponse<TEntity> where TEntity : Entity
    {
        public IQueryable<TEntity> Entities { get; set; }
    }

    public class ReadEntityUseCase<TEntity> where TEntity : Entity
    {
        private IRepository<TEntity> _repository;

        public ReadEntityUseCase(IRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public ReadEntityResponse<TEntity> Execute()
        {
            return new ReadEntityResponse<TEntity> { Entities = _repository.Read() };
        }
    }
}
