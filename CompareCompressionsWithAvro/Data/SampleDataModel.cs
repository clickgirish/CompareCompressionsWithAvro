using Microsoft.Hadoop.Avro;
using System.Runtime.Serialization;

namespace CompareCompressionsWithAvro.Data
{
    [DataContract]
    public class SampleDataModel
    {
        [DataMember]
        public bool BooleanValue { get; set; }
        [DataMember]
        public byte ByteValue { get; set; }
        [DataMember]
        public sbyte SByteValue { get; set; }
        [DataMember]
        public short ShortValue { get; set; }        
        [DataMember]
        public ushort UShortValue { get; set; }        
        [DataMember]
        public int IntValue { get; set; }
        [DataMember]
        public uint UIntValue { get; set; }
        [DataMember]
        public long LongValue { get; set; }
        [DataMember]
        public ulong ULongValue { get; set; }
        [DataMember]
        public char CharValue { get; set; }
        [DataMember]
        [NullableSchema]
        public string StringValue { get; set; }
        [DataMember]
        public float FloatValue { get; set; }
        [DataMember]
        public double DoubleValue { get; set; }
        [DataMember]
        public decimal DecimalValue { get; set; }
        [DataMember]
        public DateTime DateTimeValue { get; set; }        
        [DataMember]
        public TimeSpan TimeSpanValue { get; set; }
        [DataMember]
        public Guid GuidValue { get; set; }
    }



    //public override string ToString()
    //{
    //    return $"BooleanValue: {BooleanValue}, ByteValue: {ByteValue}, SByteValue: {SByteValue}, " +
    //           $"ShortValue: {ShortValue}, UShortValue: {UShortValue}, IntValue: {IntValue}, " +
    //           $"UIntValue: {UIntValue}, LongValue: {LongValue}, ULongValue: {ULongValue}, " +
    //           $"CharValue: {CharValue}, StringValue: {StringValue}, FloatValue: {FloatValue}, " +
    //           $"DoubleValue: {DoubleValue}, DecimalValue: {DecimalValue}, DateTimeValue: {DateTimeValue}, " +
    //           $"TimeSpanValue: {TimeSpanValue}, GuidValue: {GuidValue}";
    //}
}
