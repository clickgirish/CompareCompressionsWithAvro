using Ionic.Zlib;
using System;
using System.Collections.Generic;
//using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCompressionsWithAvro.Compressions
{
    public class DeflateCompression : ICompressionMechanism
    {
        public byte[] Compress(byte[] data)
        {
            byte[] compressedData;

            using (var ms = new MemoryStream())
            {
                using (var deflateStream = new DeflateStream(ms, CompressionMode.Compress))
                {
                    deflateStream.Write(data, 0, data.Length);
                }

                compressedData = ms.ToArray();
            }

            return compressedData;
        }

        public byte[] Decompress(byte[] compressedData)
        {
            byte[] decompressedData;

            using (var ms = new MemoryStream(compressedData))
            {
                using (var deflateStream = new DeflateStream(ms, CompressionMode.Decompress))
                {
                    using (var decompressedMs = new MemoryStream())
                    {
                        deflateStream.CopyTo(decompressedMs);
                        decompressedData = decompressedMs.ToArray();
                    }
                }
            }

            return decompressedData;
        }
    }
}
