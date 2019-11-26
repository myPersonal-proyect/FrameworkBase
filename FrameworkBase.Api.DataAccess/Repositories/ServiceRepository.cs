using FrameworkBase.Api.DataAccess.Contracts;
using FrameworkBase.Api.DataAccess.Contracts.Entities;
using FrameworkBase.Api.DataAccess.Contracts.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FrameworkBase.Api.DataAccess.Repositories
{
    public class ServiceRepository : IServiceRepository
    {
        private readonly IDataContext _context;

        public ServiceRepository(IDataContext context)
        {
            _context = context;
        }


        public async Task<ServiceEntity> Add(ServiceEntity element)
        {
            var entity = await _context.Services.AddAsync(element);
            await _context.SaveChangesAsync();

            return entity.Entity;
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Services.SingleAsync(x => x.ServiceId == id);

            _context.Services.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public Task<ServiceEntity> Exist(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceEntity> Get(int id)
        {
            return await _context.Services.FirstOrDefaultAsync(x => x.ServiceId == id);
        }

        public async Task<IEnumerable<ServiceEntity>> GetAll()
        {
            return await _context.Services.ToListAsync();
        }

        public async Task<ServiceEntity> Update(ServiceEntity objectEntity)
        {
            var entity = _context.Services.Update(objectEntity);
            await _context.SaveChangesAsync();

            return entity.Entity;
        }

        public async Task<ServiceEntity> UpdateAsync(int id, ServiceEntity element)
        {
            var entity = await Get(id);

            entity.Name = element.Name;

            _context.Services.Update(element);
            await _context.SaveChangesAsync();

            return entity;
        }
    }
}
