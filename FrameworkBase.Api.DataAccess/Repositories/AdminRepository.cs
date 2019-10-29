using FrameworkBase.Api.DataAccess.Contracts;
using FrameworkBase.Api.DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FrameworkBase.Api.DataAccess.Repositories
{
    public class OfficeRepository : IAdminRepository
    {
        private readonly IDataContext _context;


        public OfficeRepository(IDataContext context)
        {
            _context = context;
        }

        public async Task<AdminEntity> Add(AdminEntity entity)
        {
            await _context.Admins.AddAsync(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<AdminEntity> UpdateAsync(AdminEntity entity)
        {
            var update = _context.Admins.Update(entity);
            await _context.SaveChangesAsync();

            return update.Entity;
        }

        public async Task<AdminEntity> UpdateAsync(int id, AdminEntity updateEntity)
        {
            var entity = await Get(id);

            entity.Name = updateEntity.Name;

            var update = _context.Admins.Update(entity);
            await _context.SaveChangesAsync();


            return update.Entity;
        }
        public async Task<AdminEntity> Get(int id)
        {
            return await _context.Admins.Include(x => x.Office)
                                 .FirstOrDefaultAsync(x => x.AdminId == id);

        }


        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Admins.SingleAsync(x => x.AdminId == id);

            _context.Admins.Remove(entity);
            await _context.SaveChangesAsync();

        }


        public Task<IEnumerable<AdminEntity>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public async Task<AdminEntity> Update(int id, AdminEntity updateEntity)
        {
            var entity = await Get(id);


            var update = _context.Admins.Update(entity);
            await _context.SaveChangesAsync();


            return update.Entity;
        }



        public Task<AdminEntity> Exist(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
