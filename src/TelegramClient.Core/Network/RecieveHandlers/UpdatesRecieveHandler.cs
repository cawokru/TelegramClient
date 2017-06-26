﻿namespace TelegramClient.Core.Network.RecieveHandlers
{
    using System.IO;

    using BarsGroup.CodeGuard;

    using log4net;

    using OpenTl.Schema;
    using OpenTl.Schema.Serialization;

    using TelegramClient.Core.ApiServies;
    using TelegramClient.Core.IoC;
    using TelegramClient.Core.Network.RecieveHandlers.Interfaces;

    [SingleInstance(typeof(IRecieveHandler))]
    internal class UpdatesRecieveHandler: IRecieveHandler
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(UpdatesRecieveHandler));

        public int[] HandleCodes { get; } = { -1857044719, -484987010, 0x2b2fbd4e, 0x78d4dec1, 0x725b04c3, 0x74ae4240 };

        public IUpdatesApiServiceRaiser UpdateRaiser { get; set; }

        public byte[] HandleResponce(int code, BinaryReader reader)
        {
            Guard.That(reader).IsNotNull();

            var message = Serializer.DeserializeObject(reader);

            Log.Debug($"Recieve Updates - {message}");

            var updates = message as IUpdates;
            Guard.That(updates).IsNotNull();

            UpdateRaiser.OnUpdateRecieve(updates);
            return null;
        }
    }
}