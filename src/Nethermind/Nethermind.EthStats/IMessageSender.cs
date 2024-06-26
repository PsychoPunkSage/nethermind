// SPDX-FileCopyrightText: 2022 Demerzel Solutions Limited
// SPDX-License-Identifier: LGPL-3.0-only

using System.Threading.Tasks;
using Websocket.Client;

namespace Nethermind.EthStats
{
    public interface IMessageSender
    {
        Task SendAsync<T>(IWebsocketClient client, T message, string? type = null) where T : IMessage;
    }
}
