﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockShop.Core.Contracts
{
    public interface IStaffService
    {
        Task<bool> ExistsById(string userId);
    }
}
