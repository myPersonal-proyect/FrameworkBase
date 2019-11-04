using FrameworkBase.Api.DataAccess.Contracts;
using FrameworkBase.Api.DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrameworkBase.Api.DataAccess.Repositories
{
    public class AdminRepository : IAdminRepository
    {
        private readonly IDataContext _context;


        public AdminRepository(IDataContext context)
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
            var resul = await _context.Admins.Include(y => y.Office).FirstOrDefaultAsync(x => x.AdminId == id);
            return resul;

        }


        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Admins.SingleAsync(x => x.AdminId == id);

            _context.Admins.Remove(entity);
            await _context.SaveChangesAsync();

        }


        public async Task<IEnumerable<AdminEntity>> GetAll()
        {
            return await _context.Admins.Select(x => x).ToListAsync();
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
