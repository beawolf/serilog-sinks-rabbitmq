// Copyright 2015 Serilog Contributors
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Collections.Generic;
using RabbitMQ.Client;

namespace Serilog.Sinks.RabbitMQ.Sinks.RabbitMQ
{
    /// <summary>
    /// Configuration class for RabbitMqClient
    /// </summary>
    public class RabbitMQClientConfiguration
    {
        public IList<string> Hostnames { get; } = new List<string>();
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Exchange { get; set; } = string.Empty;
        public string ExchangeType { get; set; } = string.Empty;
        public RabbitMQDeliveryMode DeliveryMode { get; set; } = RabbitMQDeliveryMode.NonDurable;
        public string RouteKey { get; set; } = string.Empty;
        public int Port { get; set; }
        public string VHost { get; set; } = string.Empty;
        public IProtocol Protocol { get; set; }
        public ushort Heartbeat { get; set; }
        public bool UseBackgroundThreadsForIO { get; set; }
        public SslOption SslOption { get; set; }
        public string ClientProvidedName { get; set; }

        public RabbitMQClientConfiguration From(RabbitMQClientConfiguration config) {
            Username                    = config.Username;
            Password                    = config.Password;
            Exchange                    = config.Exchange;
            ExchangeType                = config.ExchangeType;
            DeliveryMode                = config.DeliveryMode;
            RouteKey                    = config.RouteKey;
            Port                        = config.Port;
            VHost                       = config.VHost;
            Protocol                    = config.Protocol;
            Heartbeat                   = config.Heartbeat;
            UseBackgroundThreadsForIO   = config.UseBackgroundThreadsForIO;
            SslOption                   = config.SslOption;
            ClientProvidedName          = config.ClientProvidedName;

            foreach (string hostName in config.Hostnames)
            {
                Hostnames.Add(hostName);
            }

            return this;
        }
    }
}
