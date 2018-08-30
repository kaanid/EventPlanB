using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace EventPlanB.Events
{
    public class Event : IEvent
    {
        public Event()
        {
            Id = Guid.NewGuid().ToString();
            Time = DateTime.Now;
        }
        public string Id { get ; set; }

        public DateTime Time { get; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"事件标识: {Id}");
            result.AppendLine($"事件时间: {Time.ToString("yyyy-MM-dd HH:mm:ss.fff")}");
            result.Append($"事件数据：{JsonConvert.SerializeObject(this)}");
            return result.ToString();
        }
    }
}
