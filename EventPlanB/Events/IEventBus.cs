using System;
using System.Collections.Generic;
using System.Text;

namespace EventPlanB.Events
{
    public interface IEventBus
    {
        void Pulish<TEvent>(TEvent @event) where TEvent : IEvent;
    }
}
