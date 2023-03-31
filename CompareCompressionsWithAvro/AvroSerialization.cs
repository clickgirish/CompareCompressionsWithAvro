using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Avro.Generic;
using CompareCompressionsWithAvro.Data;
using Microsoft.Hadoop.Avro.Container;
using Microsoft.Hadoop.Avro;
using Avro;

namespace CompareCompressionsWithAvro
{
    public class AvroSerialization : ICompressionMechanism
    {
        public byte[] Compress(byte[] data)
        {
            throw new NotImplementedException();
        }

        public byte[] Decompress(byte[] compressedData)
        {
            throw new NotImplementedException();
        }
    }
}
