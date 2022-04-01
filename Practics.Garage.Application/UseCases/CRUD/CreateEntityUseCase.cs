using Practics.Garage.Domain.Models.Base;
using Practics.Garage.Domain.Repository.Base;
using System.Threading.Tasks;

namespace Practics.Garage.Application.UseCases.CRUD
{

    public class CreateEntityRequest<TEntity> where TEntity : Entity
    {
        public TEntity Entity { get; set; }

        public CreateEntityRequest(TEntity entity)
        {
            Entity = entity;
        }
    }

    public class CreateEntityResponse<TEntity> where TEntity : Entity
    {
        public TEntity Entity { get; set; }

        public CreateEntityResponse(TEntity entity)
        {
            Entity = entity;
        }
    }

    public class CreateEntityUseCase<TEntity> where TEntity : Entity
    {
        private IRepository<TEntity> _repository;

        public CreateEntityUseCase(IRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public async Task<CreateEntityResponse<TEntity>> Execute(CreateEntityRequest<TEntity> request)
        {
            var entity = request.Entity;
            var result = await _repository.Create(entity);
            return new CreateEntityResponse<TEntity>(result);
        }
    }
}
