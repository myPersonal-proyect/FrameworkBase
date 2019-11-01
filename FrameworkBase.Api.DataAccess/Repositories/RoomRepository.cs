using FrameworkBase.Api.DataAccess.Contracts;
using FrameworkBase.Api.DataAccess.Contracts.Entities;
using FrameworkBase.Api.DataAccess.Contracts.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FrameworkBase.Api.DataAccess.Repositories
{
    public class RoomRepository : IRoomRepository
    {
        private readonly IDataContext _context;


        public RoomRepository(IDataContext context)
        {
            _context = context;
        }


        public async Task<RoomEntity> Add(RoomEntity element)
        {
            await _context.Rooms.AddAsync(element);
            await _context.SaveChangesAsync();

            return element;
        }

        public async Task<IEnumerable<RoomEntity>> GetAll()
        {
            return await _context.Rooms.ToListAsync();
        }

        public async Task<RoomEntity> Update(RoomEntity entity)
        {
            var update = _context.Rooms.Update(entity);
            await _context.SaveChangesAsync();

            return update.Entity;
        }

        public async Task<RoomEntity> UpdateAsync(int id, RoomEntity element)
        {
            var entity = await Get(id);

            entity.Name = element.Name;

            var update = _context.Rooms.Update(entity);
            await _context.SaveChangesAsync();


            return update.Entity;
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Rooms.SingleAsync(x => x.Id == id);

            _context.Rooms.Remove(entity);
            await _context.SaveChangesAsync();
        }


        public async Task<RoomEntity> Get(int id)
        {
            return await _context.Rooms.Include(x => x.Office2Rooms)
                                 .FirstOrDefaultAsync(x => x.Id == id);

        }


        public Task<RoomEntity> Exist(int id)
        {
            throw new NotImplementedException();
        }


    }
}
