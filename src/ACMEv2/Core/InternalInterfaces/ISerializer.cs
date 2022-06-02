﻿namespace CronBlocks.ACMEv2.Core.InternalInterfaces
{
    internal interface ISerializer
    {
        string SerializeToJson<T>(T obj);
        T DeserializeFromJson<T>(string json);

        string SerializeToBase64(byte[] bytes, bool trimTrailingEquals = false);
        byte[] DeserializeFromBase64(string serializedBase64);
    }
}