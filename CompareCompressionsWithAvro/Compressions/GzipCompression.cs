using Ionic.Zlib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCompressionsWithAvro.Compressions
{
    public class GzipCompression : ICompressionMechanism
    {
        public byte[] Compress(byte[] data)
        {
            byte[] compressedData;

            using (var ms = new MemoryStream())
            {
                using (var gzipStream = new GZipStream(ms, CompressionMode.Compress))
                {
                    gzipStream.Write(data, 0, data.Length);
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
                using (var gzipStream = new GZipStream(ms, CompressionMode.Decompress))
                {
                    using (var decompressedMs = new MemoryStream())
                    {
                        gzipStream.CopyTo(decompressedMs);
                        decompressedData = decompressedMs.ToArray();
                    }
                }
            }

            return decompressedData;
        }
    }

}
