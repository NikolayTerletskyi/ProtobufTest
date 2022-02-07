using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtobufTest
{
    [ProtoContract]
    public class TestDTO : IEquatable<TestDTO?>
    {
        [ProtoMember(1)]
        public string Text { get; set; }

        [ProtoMember(2)]
        public string Text2 { get; set; }

        [ProtoMember(3)]
        public string Text3 { get; set; }

        [ProtoMember(4)]
        public string Text4 { get; set; }

        [ProtoMember(5)]
        public int Int5 { get; set; }

        [ProtoMember(6)]
        public int Int6 { get; set; }

        [ProtoMember(7)]
        public int Int7 { get; set; }

        [ProtoMember(8)]
        public int Int8 { get; set; }

        [ProtoMember(9)]
        public int Int9 { get; set; }

        [ProtoMember(10)]
        public int Int10 { get; set; }

        public override bool Equals(object? obj)
        {
            return Equals(obj as TestDTO);
        }

        public bool Equals(TestDTO? other)
        {
            return other != null &&
                   Text == other.Text &&
                   Text2 == other.Text2 &&
                   Text3 == other.Text3 &&
                   Text4 == other.Text4 &&
                   Int5 == other.Int5 &&
                   Int6 == other.Int6 &&
                   Int7 == other.Int7 &&
                   Int8 == other.Int8 &&
                   Int9 == other.Int9 &&
                   Int10 == other.Int10;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(Text);
            hash.Add(Text2);
            hash.Add(Text3);
            hash.Add(Text4);
            hash.Add(Int5);
            hash.Add(Int6);
            hash.Add(Int7);
            hash.Add(Int8);
            hash.Add(Int9);
            hash.Add(Int10);
            return hash.ToHashCode();
        }

        public static bool operator ==(TestDTO? left, TestDTO? right)
        {
            return EqualityComparer<TestDTO>.Default.Equals(left, right);
        }

        public static bool operator !=(TestDTO? left, TestDTO? right)
        {
            return !(left == right);
        }
    }
}
