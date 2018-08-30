using EventPlanB.Events;
using EventPlanB.Events.Handlers;
using EventPlanB.Events.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace EventPlanB.Console
{
    public class EventSample : Event
    {
        public string Name { get; set; }
    }

    public class EventHandlerManagerSample : IEventHandlerManager
    {
        private readonly IEventHandler[] _handlers;
        public EventHandlerManagerSample(params IEventHandler[] handlers)
        {
            _handlers = handlers;
        }
        public List<IEventHandler<TEvent>> GetHandlers<TEvent>() where TEvent : IEvent
        {
            return _handlers.Select(t => t as IEventHandler<TEvent>).ToList();
        }
    }

    public class MessageEventSample: MessageEvent
    {
        public string Name { get; set; }
    }

    public class MessageEventBusSample : IMessageEventBus
    {
        public Task Publish<TEvent>(TEvent @event) where TEvent : IMessageEvent
        {
            WriteLine("============================");
            WriteLine("MessageEventBusSample");
            WriteLine(@event.ToString());
            WriteLine("============================");

            return Task.CompletedTask;
        }
    }

    public class EventHandlerSample : IEventHandler<EventSample>
    {
        private readonly string _str;
        public EventHandlerSample(string str)
        {
            _str = str;
        }
        public void Handle(EventSample @event)
        {
            WriteLine("============================");
            WriteLine($"str:{_str}");
            WriteLine(@event.ToString());
            WriteLine("============================");
        }
    }
}
