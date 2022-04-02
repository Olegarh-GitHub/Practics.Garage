using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Practics.Garage.Domain.Models.Base;
using System.Linq;
using Practics.Garage.Infrastructure.Contexts;
using System.Threading.Tasks;
using Practics.Garage.Infrastructure.AutoMapping;
using Practics.Garage.Domain.Repository.Base;
using System;

namespace Practics.Garage.Infrastructure.Repositories.Base
{
    public class Repository<TEntity> : IRepository<TEntity>
    where TEntity : Entity
    {
        private readonly IMapper _mapper;
        private readonly ApplicationContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public Repository(ApplicationContext context)
        {
            _context = context;
            _mapper = new Mapper(new MapperConfiguration(configuration => configuration.AddProfile<EntityMappingProfile>()));
            _dbSet = _context.Set<TEntity>();
        }

        public async Task<TEntity> Create(TEntity entity)
        {
            var existedEntity = await _dbSet.FirstOrDefaultAsync(x => x.IdGuid == entity.IdGuid);

            if (existedEntity != null)
                return null;

            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public IQueryable<TEntity> Read()
        {
            return _dbSet.AsQueryable();
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            var existedEntity = await _dbSet.FirstOrDefaultAsync(x => x.IdGuid == entity.IdGuid);

            if (existedEntity == null)
                return null;

            _mapper.Map(entity, existedEntity);

            existedEntity.UpdatedAt = DateTime.Now;

            _dbSet.Update(existedEntity);
            await _context.SaveChangesAsync();

            return existedEntity;
        }

        public async Task<bool> Delete(TEntity entity)
        {
            var existedEntity = await _dbSet.FirstOrDefaultAsync(x => x.IdGuid == entity.IdGuid);

            if (existedEntity == null)
                return false;

            _dbSet.Remove(existedEntity);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
