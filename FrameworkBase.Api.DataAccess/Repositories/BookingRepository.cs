using FrameworkBase.Api.DataAccess.Contracts;
using FrameworkBase.Api.DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FrameworkBase.Api.DataAccess.Repositories
{
    public class BookingRepository : IBookingRepository
    {
        private readonly IDataContext _context;

        public BookingRepository(IDataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<BookingEntity>> GetAll()
        {
            return await _context.Bookings.ToListAsync();
        }


        public async Task<BookingEntity> Add(BookingEntity entity)
        {
            {
                await _context.Bookings.AddAsync(entity);
                await _context.SaveChangesAsync();

                return entity;
            }

        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Bookings.SingleAsync(x => x.Id == id);

            _context.Bookings.Remove(entity);
            await _context.SaveChangesAsync();
        }



        public async Task<BookingEntity> Get(int id)
        {
            return await _context.Bookings.Include(x => x.Office)
                                                       .FirstOrDefaultAsync(x => x.Id == id);
        }


        public async Task<BookingEntity> Update(BookingEntity entity)
        {
            var update = _context.Bookings.Update(entity);
            await _context.SaveChangesAsync();

            return update.Entity;
        }

        public async Task<BookingEntity> UpdateAsync(int id, BookingEntity element)
        {
            var entity = await Get(id);

            entity.RentWorkSpace = element.RentWorkSpace;

            var update = _context.Bookings.Update(entity);
            await _context.SaveChangesAsync();


            return update.Entity;
        }

        public Task<BookingEntity> Exist(int id)
        {
            throw new System.NotImplementedException();
        }


    }
}
