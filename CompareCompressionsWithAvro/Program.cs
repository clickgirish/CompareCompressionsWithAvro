

using CompareCompressionsWithAvro;
/// Avro: https://www.nuget.org/packages/Apache.Avro/
/// Bzip (Deprecated): https://www.nuget.org/packages/BZip2
/// 


var benchmark = new CompressionBenchmark();
benchmark.Run();

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
