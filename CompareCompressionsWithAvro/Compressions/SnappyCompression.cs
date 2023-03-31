using System.IO;
// using System.IO.Compression;
using IronSnappy;

public class SnappyCompression : ICompressionMechanism
{
    public byte[] Compress(byte[] data)
    {
        if (data == null || data.Length == 0)
            return data;
        
        byte[] compressed = Snappy.Encode(data);

        return compressed;
    }

    public byte[] Decompress(byte[] compressedData)
    {
        if (compressedData == null || compressedData.Length == 0)
            return compressedData;
        
        byte[] uncompressed = Snappy.Decode(compressedData);

        return uncompressed;
    }
}
