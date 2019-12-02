using Microsoft.Extensions.DependencyInjection;
using System;

namespace Demo.Services
{
    public static class Bootstrapper
    {
        public static void UseServices(this IServiceCollection services)
        {
            services.AddHttpClient<ITodoService, TodoService>();
        }
    }
}