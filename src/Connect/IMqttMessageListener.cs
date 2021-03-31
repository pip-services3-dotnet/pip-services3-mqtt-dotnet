using System;
using MQTTnet;

namespace PipServices3.Mqtt.Connect
{
    public interface IMqttMessageListener
    {
        void OnMessage(MqttApplicationMessage message);
    }
}
