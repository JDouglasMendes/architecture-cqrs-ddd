﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DM.Services.API.Configurations
{
    public static class DependencyInjectionSetup
    {
        public static void AddDependencyInjectionSetup(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            //NativeInjectorBootStrapper.RegisterServices(services);
        }
    }
}
