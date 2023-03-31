//using Ionic.Zlib;
using Ionic.BZip2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCompressionsWithAvro.Compressions
{
    public class Bzip2Compression : ICompressionMechanism
    {
        public byte[] Compress(byte[] data)
        {
            if (data == null || data.Length == 0)
                return data;

            using var inputStream = new MemoryStream(data);
            using var outputStream = new MemoryStream();
            using var bzip2Stream = new BZip2OutputStream(outputStream);
            inputStream.CopyTo(bzip2Stream);
            bzip2Stream.Close();

            return outputStream.ToArray();
        }

        public byte[] Decompress(byte[] compressedData)
        {
            if (compressedData == null || compressedData.Length == 0)
                return compressedData;

            using var inputStream = new MemoryStream(compressedData);
            using var outputStream = new MemoryStream();
            using var bzip2Stream = new BZip2InputStream(inputStream);
            bzip2Stream.CopyTo(outputStream);
            bzip2Stream.Close();

            return outputStream.ToArray();
        }
    }
}
