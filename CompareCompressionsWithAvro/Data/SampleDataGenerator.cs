namespace CompareCompressionsWithAvro.Data
{
    public class SampleDataGenerator
    {
        public static List<SampleDataModel> GenerateSampleData(int count)
        {
            var sampleData = new List<SampleDataModel>();
            var random = new Random();

            for (int i = 0; i < count; i++)
            {
                var model = new SampleDataModel
                {
                    BooleanValue = random.Next(0, 2) == 1,
                    ByteValue = (byte)random.Next(byte.MinValue, byte.MaxValue),
                    SByteValue = (sbyte)random.Next(sbyte.MinValue, sbyte.MaxValue),
                    ShortValue = (short)random.Next(short.MinValue, short.MaxValue),
                    UShortValue = (ushort)random.Next(ushort.MinValue, ushort.MaxValue),
                    IntValue = random.Next(int.MinValue, int.MaxValue),
                    UIntValue = (uint)random.Next(int.MinValue, int.MaxValue),
                    LongValue = ((long)random.Next(int.MinValue, int.MaxValue) << 32) | (uint)random.Next(int.MinValue, int.MaxValue),
                    ULongValue = (ulong)(((long)random.Next(int.MinValue, int.MaxValue) << 32) | (uint)random.Next(int.MinValue, int.MaxValue)),
                    CharValue = (char)random.Next(char.MinValue, char.MaxValue),
                    StringValue = Guid.NewGuid().ToString(),
                    FloatValue = (float)random.NextDouble() * (float.MaxValue - float.MinValue) + float.MinValue,
                    DoubleValue = random.NextDouble() * (double.MaxValue - double.MinValue) + double.MinValue,
                    DecimalValue = new decimal(new int[] { random.Next(int.MinValue, int.MaxValue), random.Next(int.MinValue, int.MaxValue), random.Next(int.MinValue, int.MaxValue), random.Next(0, 2) == 0 ? 0 : int.MinValue }),
                    DateTimeValue = new DateTime(random.Next(1900, 2100), random.Next(1, 13), random.Next(1, 29), random.Next(0, 24), random.Next(0, 60), random.Next(0, 60), DateTimeKind.Utc),
                    TimeSpanValue = TimeSpan.FromTicks(random.Next(0, int.MaxValue)),
                    GuidValue = Guid.NewGuid()
                };

                sampleData.Add(model);
            }

            return sampleData;
        }
    }
}
