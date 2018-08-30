using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanB.Events.Messages
{
    public interface IMessageEventBus
    {
        Task Publish<TEvent>(TEvent @event) where TEvent : IMessageEvent;
    }
}
