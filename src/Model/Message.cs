using ProtoBuf;

namespace NancyTest.Model
{
    [ProtoContract]
    public class Message
    {
        [ProtoMember(1)]
        public string Msg { get; set; }
    }
}
