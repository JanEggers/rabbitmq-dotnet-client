﻿using System.Collections.Generic;

namespace RabbitMQ.Client
{
    public interface IRecordedConsumer
    {
        IBasicConsumer Consumer { get; }

        string ConsumerTag { get; }

        string Queue { get; }

        bool AutoAck { get; }

        bool Exclusive { get; }

        IDictionary<string, object> Arguments { get; }
    }
}
