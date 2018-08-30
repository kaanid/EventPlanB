using EventPlanB.Events.Handlers;
using EventPlanB.Events.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventPlanB.Events.Default
{
    public class EventBus : IEventBus
    {
        public EventBus(IEventHandlerManager manager,IMessageEventBus messageEventBus = null)
        {
            Manager = manager;
            MessageEventBus = messageEventBus;
        }
        public IEventHandlerManager Manager { get; set; }
        public IMessageEventBus MessageEventBus { get; set; }
        public void Pulish<TEvent>(TEvent @event) where TEvent : IEvent
        {
            SyncHandle(@event);
            if (@event is IMessageEvent messageEvent)
                AsyncHandle(messageEvent);
        }
        private void SyncHandle<TEvent>(TEvent @event) where TEvent : IEvent
        {
            var handlers = Manager.GetHandlers<TEvent>();
            if (handlers == null)
                return;
            foreach (var handler in handlers)
                handler?.Handle(@event);
        }

        private void AsyncHandle(IMessageEvent messageEvent)
        {
            MessageEventBus?.Publish(messageEvent);
        }
    }
}
