using FrameworkBase.Api.DataAccess.Contracts;
using FrameworkBase.Api.DataAccess.Contracts.Entities;
using FrameworkBase.Api.DataAccess.Contracts.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FrameworkBase.Api.DataAccess.Repositories
{
    public class OfficeRepoository : IOfficeRepository
    {
        private readonly IDataContext context;

        public OfficeRepoository(IDataContext context)
        {
            this.context = context;
        }


        public async Task<OfficeEntity> Add(OfficeEntity element)
        {
            await context.Offices.AddAsync(element);
            await context.SaveChangesAsync();
            return element;
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await context.Offices.SingleAsync(x => x.Id == id);

            context.Offices.Remove(entity);
            await context.SaveChangesAsync();
        }


        public async Task<OfficeEntity> Get(int id)
        {
            return await context.Offices.Include(x => x.Booking)
                                                       .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<OfficeEntity>> GetAll()
        {
            return await context.Offices.ToListAsync();
        }

        public async Task<OfficeEntity> Update(OfficeEntity entity)
        {
            var update = context.Offices.Update(entity);
            await context.SaveChangesAsync();

            return update.Entity;
        }

        public async Task<OfficeEntity> UpdateAsync(int id, OfficeEntity element)
        {
            var entity = await Get(id);

            entity.Name = element.Name;


            var update = context.Offices.Update(entity);
            await context.SaveChangesAsync();


            return update.Entity;
        }

        public Task<OfficeEntity> Exist(int id)
        {
            throw new NotImplementedException();
        }

    }
}
