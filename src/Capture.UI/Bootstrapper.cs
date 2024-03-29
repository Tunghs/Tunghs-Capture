﻿using CommunityToolkit.Mvvm.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace Capture.UI
{
    public class Bootstrapper
    {
        public Bootstrapper()
        {
            var services = ConfigureServices();
            Ioc.Default.ConfigureServices(services);
        }

        /// <summary>
        /// Configures the services for the application.
        /// </summary>
        /// <returns></returns>
        private static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            // ViewModel 등록
            return services.BuildServiceProvider();
        }
    }
}
