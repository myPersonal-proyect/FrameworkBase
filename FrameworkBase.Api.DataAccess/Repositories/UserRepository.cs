using FrameworkBase.Api.DataAccess.Contracts;
using FrameworkBase.Api.DataAccess.Contracts.Entities;
using FrameworkBase.Api.DataAccess.Contracts.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FrameworkBase.Api.DataAccess.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IDataContext _context;

        public UserRepository(IDataContext context)
        {
            _context = context;
        }


        public async Task<UserEntity> Add(UserEntity element)
        {
            await _context.Users.AddAsync(element);
            await _context.SaveChangesAsync();
            return element;
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Users.SingleAsync(x => x.Id == id);

            _context.Users.Remove(entity);
            await _context.SaveChangesAsync();
        }


        public async Task<UserEntity> Get(int id)
        {
            return await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<UserEntity>> GetAll()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<UserEntity> Update(UserEntity objectEntity)
        {
            var entity = _context.Users.Update(objectEntity);
            await _context.SaveChangesAsync();
            return entity.Entity;
        }

        public async Task<UserEntity> UpdateAsync(int id, UserEntity element)
        {
            var entity = await Get(id);

            entity.Name = element.Name;
            entity.Email = element.Email;

            _context.Users.Update(element);
            await _context.SaveChangesAsync();

            return entity;
        }

        public Task<UserEntity> Exist(int id)
        {
            throw new NotImplementedException();
        }

    }
}
