using System;
using PipServices3.Commons.Refer;
using PipServices3.Mqtt.Queues;
using Xunit;

namespace PipServices3.Mqtt.Build
{
    public class MqttMessageQueueFactoryTest : IDisposable
	{

		public void Dispose()
		{ }

		[Fact]
		public void TestFactoryCreateMessageQueue()
		{
			var factory = new MqttMessageQueueFactory();
			var descriptor = new Descriptor("pip-services", "message-queue", "mqtt", "test", "1.0");

			var canResult = factory.CanCreate(descriptor);
			Assert.NotNull(canResult);

			var queue = factory.Create(descriptor) as MqttMessageQueue;
			Assert.NotNull(queue);
			Assert.Equal("test", queue.Name);
		}

	}
}
