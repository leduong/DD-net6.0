﻿using App.Application.Services.Common;
using App.Infrastructure.Persistence.Repositories;
using App.Infrastructure.ServiceAgents;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application
{
    public class ApplicationDIConfig
    {
        public static void AddConfig(IServiceCollection services)
        {
            services.AddScoped(typeof(IBaseService<>), typeof(BaseService<>));
        
        }
    }
}
