using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventPlanB.Events.Messages
{
    public class MessageEvent:Event,IMessageEvent
    {
        public object Data { get; set; }
        public string Target { get; set; }
        public string Callback { get; set; }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"事件标识: {Id}");
            result.AppendLine($"事件时间:{Time.ToString("yyyy-MM-dd HH:mm:ss.fff")}");
            if (string.IsNullOrWhiteSpace(Target) == false)
                result.AppendLine($"发送目标:{Target}");
            if (string.IsNullOrWhiteSpace(Callback) == false)
                result.AppendLine($"回调:{Callback}");
            result.Append($"事件数据：{JsonConvert.SerializeObject(Data)}");
            return result.ToString();
        }
    }
}
