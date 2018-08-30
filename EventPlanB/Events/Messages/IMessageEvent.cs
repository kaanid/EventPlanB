using System;
using System.Collections.Generic;
using System.Text;

namespace EventPlanB.Events.Messages
{
    public interface IMessageEvent:IEvent
    {
        object Data { get; set; }
        string Target { get; set; }
        string Callback { get; set; }
    }
}
