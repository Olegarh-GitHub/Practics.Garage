using Practics.Garage.Domain.Models.Base;
using Practics.Garage.Domain.Repository.Base;
using System.Threading.Tasks;

namespace Practics.Garage.Application.UseCases.CRUD
{
    public class DeleteEntityRequest<TEntity> where TEntity : Entity
    {
        public TEntity Entity { get; set; }

        public DeleteEntityRequest(TEntity entity)
        {
            Entity = entity;
        }
    }

    public class DeleteEntityResponse
    {
        public bool Success { get; set; }
    }
    public class DeleteEntityUseCase<TEntity> where TEntity : Entity
    {
        private IRepository<TEntity> _repository { get; set; }

        public DeleteEntityUseCase(IRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public async Task<DeleteEntityResponse> Execute(DeleteEntityRequest<TEntity> request)
        {
            var deleted = await _repository.Delete(request.Entity);
            return new DeleteEntityResponse() { Success = deleted };
        }
    }
}
