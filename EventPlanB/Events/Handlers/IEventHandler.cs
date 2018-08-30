using System;
using System.Collections.Generic;
using System.Text;

namespace EventPlanB.Events.Handlers
{
    public interface IEventHandler
    {
    }

    public interface IEventHandler<in TEvent>:IEventHandler where TEvent : IEvent
    {
        void Handle(TEvent @event);
    }
}
