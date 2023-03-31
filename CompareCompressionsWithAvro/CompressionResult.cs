namespace CompareCompressionsWithAvro
{
    public class CompressionResult
    {
        public string CompressionMechanism { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public TimeSpan TimeConsumed { get; set; }
    }
}
