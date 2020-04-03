using AutoMapper;
using DM.Application.AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DM.Services.API.Configurations
{
    public static class AutoMapperSetup
    {
        public static void AddAutoMapperSetup(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            _ = services.AddAutoMapper(typeof(DomainToViewModelMappingProfile), typeof(ViewModelToDomainMappingProfile));
        }
    }
}
