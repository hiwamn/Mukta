﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Contracts
{
    public interface IDeviceRepository : IRepository<Device>
    {
        bool IsExist(Guid userId, string deviceId);
    }
}
