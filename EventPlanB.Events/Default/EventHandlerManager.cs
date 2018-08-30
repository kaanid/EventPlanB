using EventPlanB.Events.Handlers;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventPlanB.Events.Default
{
    public class EventHandlerManager : IEventHandlerManager
    {
        public List<IEventHandler<TEvent>> GetHandlers<TEvent>() where TEvent : IEvent
        {
            return Ioc.CreateList<IEventHandler<TEvent>>();
        }
    }

    public class Ioc
    {
        public static List<T> CreateList<T>()
        {
            Type serviceType = typeof(IEnumerable<>).MakeGenericType(typeof(T));
            return new List<T>();
        }
    }
}
