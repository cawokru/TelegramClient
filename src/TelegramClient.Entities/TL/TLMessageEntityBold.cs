using System.IO;

namespace TelegramClient.Entities.TL
{
    [TLObject(-1117713463)]
    public class TLMessageEntityBold : TLAbsMessageEntity
    {
        public override int Constructor => -1117713463;

        public int offset { get; set; }
        public int length { get; set; }


        public void ComputeFlags()
        {
        }

        public override void DeserializeBody(BinaryReader br)
        {
            offset = br.ReadInt32();
            length = br.ReadInt32();
        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            bw.Write(offset);
            bw.Write(length);
        }
    }
}