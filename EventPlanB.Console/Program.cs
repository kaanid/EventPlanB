using EventPlanB.Events.Default;
using System;
using static System.Console;

namespace EventPlanB.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Hello World!");

            var _handler = new EventHandlerSample("A");
            var _handler2 = new EventHandlerSample("B");
            var manage = new EventHandlerManagerSample(_handler, _handler2);

            var messageEventBus = new MessageEventBusSample();

            var eventBus = new EventBus(manage, messageEventBus);

            var @event = new EventSample { Name = "Bbbbbb" };
            eventBus.Pulish(@event);

            var messageEvent = new MessageEventSample() { Name="OKKKKKKKKKKKKKK",Callback="sdfsdfsdfsdfs",Target="Heee",Data="AAAAAAAAAAAAA"};
            eventBus.Pulish(messageEvent);

            ReadLine();

        }
    }
}
