using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Practics.Garage.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Practics.Garage.Infrastructure.Contexts;
using System.Threading.Tasks;
using Practics.Garage.Infrastructure.AutoMapping;

namespace Practics.Garage.Infrastructure.Repositories
{
    public class Repository<TEntity>
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

        public async Task<TEntity> CreateAsync(TEntity entity)
        {
            var existedEntity = await _dbSet.FirstOrDefaultAsync(x => x.IdGuid == entity.IdGuid);

            if (existedEntity != null)
                return null;

            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            var existedEntity = await _dbSet.FirstOrDefaultAsync(x => x.IdGuid == entity.IdGuid);

            if (existedEntity == null)
                return null;

            _mapper.Map(entity, existedEntity);

            _dbSet.Update(existedEntity);
            await _context.SaveChangesAsync();

            return existedEntity;
        }

        public IQueryable<TEntity> Read()
        {
            return _dbSet.AsQueryable();
        }

        public async Task<bool> DeleteAsync(TEntity entity)
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
