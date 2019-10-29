﻿using FrameworkBase.Api.DataAccess.Contracts.Entities;
using System.Threading.Tasks;

namespace FrameworkBase.Api.DataAccess.Contracts.Repositories
{
    public interface IRoomRepository : IRepository<RoomEntity>
    {
        Task<OfficeEntity> Update(OfficeEntity entity);
    }
}
