﻿using System;
using System.Threading.Tasks;
using Identity.Admin.BusinessLogic.Dtos.Log;

namespace Identity.Admin.BusinessLogic.Services.Interfaces
{
    public interface IAuditLogService
    {
        Task<AuditLogsDto> GetAsync(AuditLogFilterDto filters);

        Task DeleteLogsOlderThanAsync(DateTime deleteOlderThan);
    }
}
