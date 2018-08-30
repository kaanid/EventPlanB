using System;
using System.Collections.Generic;
using System.Text;

namespace EventPlanB.Events.Handlers
{
    public interface IEventHandlerManager
    {
        List<IEventHandler<TEvent>> GetHandlers<TEvent>() where TEvent : IEvent;
    }
}
