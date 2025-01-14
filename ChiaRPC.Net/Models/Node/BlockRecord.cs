﻿using ChiaRPC.Parsers;
using System.Numerics;
using System.Text.Json.Serialization;

namespace ChiaRPC.Models
{
    public sealed class BlockRecord
    {
        [JsonPropertyName("header_hash")]
        [JsonConverter(typeof(HexBytesConverter))]
        public HexBytes HeaderHash { get; init; }

        [JsonPropertyName("height")]
        public ulong Height { get; init; }

        [JsonPropertyName("weight")]
        [JsonConverter(typeof(BigIntegerConverter))]
        public BigInteger Weight { get; init; }

        [JsonConstructor]
        public BlockRecord()
        {
        }
    }
}
