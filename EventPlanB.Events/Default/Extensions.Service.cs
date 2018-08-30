using System;
using System.Collections.Generic;
using System.Text;
using EventPlanB.Events.Handlers;
using Microsoft.Extensions.DependencyInjection;

namespace EventPlanB.Events.Default
{
    public static class Extensions
    {
        public static void AddEventBus(this IServiceCollection services)
        {
            services.AddSingleton<IEventHandlerManager, EventHandlerManager>();
            services.AddSingleton<IEventBus, EventPlanB.Events.Default.EventBus>();
        }
    }
}
