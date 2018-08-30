using System;
using System.Collections.Generic;
using System.Text;

namespace EventPlanB.Events
{
    public interface IEvent
    {
        string Id { get; set; }

        DateTime Time { get; }
    }
}
