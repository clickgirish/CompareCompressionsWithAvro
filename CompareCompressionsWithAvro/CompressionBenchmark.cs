using CompareCompressionsWithAvro.Compressions;
using CompareCompressionsWithAvro.Data;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCompressionsWithAvro
{
    public class CompressionBenchmark
    {
        private const int SampleDataCount = 10000;

        private readonly byte[] _sampleData;

        private readonly SnappyCompression _snappyCompression = new SnappyCompression();
        private readonly DeflateCompression _deflateCompression = new DeflateCompression();
        private readonly GzipCompression _gzipCompression = new GzipCompression();
        private readonly Bzip2Compression _bzip2Compression = new Bzip2Compression();

        public CompressionBenchmark()
        {
            _sampleData = GenerateSampleData();
        }

        public void Run()
        {
            var results = new List<CompressionResult>();

            // Snappy
            var snappyResult = TestCompression(_snappyCompression, "Snappy");
            results.Add(snappyResult);

            // Deflate
            var deflateResult = TestCompression(_deflateCompression, "Deflate");
            results.Add(deflateResult);

            // GZip
            var gzipResult = TestCompression(_gzipCompression, "GZip");
            results.Add(gzipResult);

            // BZip2
            var bzip2Result = TestCompression(_bzip2Compression, "BZip2");
            results.Add(bzip2Result);

            // Write results to CSV
            using (var writer = new StreamWriter("results.csv"))
            using (var csv = new CsvWriter(writer, System.Globalization.CultureInfo.InvariantCulture))
            {
                csv.WriteHeader<CompressionResult>();
                csv.NextRecord();
                csv.WriteRecords(results);
            }
        }

        private CompressionResult TestCompression(ICompressionMechanism compressionMechanism, string compressionMechanismName)
        {
            var result = new CompressionResult
            {
                CompressionMechanism = compressionMechanismName,
                StartTime = DateTime.Now,
            };

            var compressedData = compressionMechanism.Compress(_sampleData);

            result.EndTime = DateTime.Now;
            result.TimeConsumed = result.EndTime - result.StartTime;

            compressionMechanism.Decompress(compressedData);

            return result;
        }

        private byte[] GenerateSampleData()
        {
            var sampleData = SampleDataGenerator.GenerateSampleData(10000);
            //var bytes = new AvroSerialization().Compress(sampleData);

            //return bytes;
            return null; // TODO: Fix this
        }
    }
}
