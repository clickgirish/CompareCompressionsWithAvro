public interface ICompressionMechanism
{
    byte[] Compress(byte[] data);
    byte[] Decompress(byte[] compressedData);
}
