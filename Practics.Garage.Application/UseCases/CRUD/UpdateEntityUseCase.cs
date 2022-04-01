using Practics.Garage.Domain.Models.Base;
using Practics.Garage.Domain.Repository.Base;
using System.Threading.Tasks;

namespace Practics.Garage.Application.UseCases.CRUD
{
    public class UpdateEntityRequest<TEntity> where TEntity : Entity
    {
        public TEntity Entity { get; set; }
    }

    public class UpdateEntityResponse<TEntity> where TEntity : Entity
    {
        public TEntity Entity { get; set; }

        public UpdateEntityResponse(TEntity entity)
        {
            Entity = entity;
        }
    }

    public class UpdateEntityUseCase<TEntity> where TEntity : Entity
    {
        private IRepository<TEntity> _repository;
        public UpdateEntityUseCase(IRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public async Task<UpdateEntityResponse<TEntity>> Execute(UpdateEntityRequest<TEntity> request)
        {
            var entity = await _repository.Update(request.Entity);
            return new UpdateEntityResponse<TEntity>(entity);
        }
    }
}
