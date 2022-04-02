using Practics.Garage.Application.UseCases.CRUD;
using Practics.Garage.Domain.Models.Base;
using Practics.Garage.Domain.Repository.Base;
using System.Linq;
using System.Threading.Tasks;

namespace Practics.Garage.Application.Facades.Base
{
    public class EntityFacade<TEntity> where TEntity : Entity
    {
        protected IRepository<TEntity> _repository;

        protected CreateEntityUseCase<TEntity> _createUseCase;
        protected ReadEntityUseCase<TEntity> _readUseCase;
        protected UpdateEntityUseCase<TEntity> _updateUseCase;
        protected DeleteEntityUseCase<TEntity> _deleteUseCase;

        public EntityFacade(IRepository<TEntity> repository)
        {
            _repository = repository;

            _createUseCase = new CreateEntityUseCase<TEntity>(_repository);
            _readUseCase = new ReadEntityUseCase<TEntity>(_repository);
            _updateUseCase = new UpdateEntityUseCase<TEntity>(_repository);
            _deleteUseCase = new DeleteEntityUseCase<TEntity>(_repository);
        }

        public async Task<TEntity> Create(TEntity entity)
        {
            var request = new CreateEntityRequest<TEntity>(entity);
            var response = await _createUseCase.Execute(request);
            return response.Entity;
        }

        public IQueryable<TEntity> Read()
        {
            return _readUseCase.Execute().Entities;
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            var request = new UpdateEntityRequest<TEntity>(entity);
            var response = await _updateUseCase.Execute(request);
            return response.Entity;
        }

        public async Task<bool> Delete(TEntity entity)
        {
            var request = new DeleteEntityRequest<TEntity>(entity);
            var response = await _deleteUseCase.Execute(request);
            return response.Success;
        }
    }
}
