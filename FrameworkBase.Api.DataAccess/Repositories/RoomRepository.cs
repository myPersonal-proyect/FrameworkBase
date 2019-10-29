using FrameworkBase.Api.DataAccess.Contracts.Entities;
using FrameworkBase.Api.DataAccess.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkBase.Api.DataAccess.Repositories
{
    public class RoomRepository : IRoomRepository
    {
        public Task<RoomEntity> Add(RoomEntity element)
        {
            throw new NotImplementedException();
        }
        public Task<IEnumerable<RoomEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<OfficeEntity> Update(OfficeEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<RoomEntity> UpdateAsync(int id, RoomEntity element)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<RoomEntity> Exist(int id)
        {
            throw new NotImplementedException();
        }

        public Task<RoomEntity> Get(int id)
        {
            throw new NotImplementedException();
        }

      
    }
}
