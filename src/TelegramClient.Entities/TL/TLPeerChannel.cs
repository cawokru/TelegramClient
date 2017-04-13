using System.IO;

namespace TelegramClient.Entities.TL
{
    [TLObject(-1109531342)]
    public class TLPeerChannel : TLAbsPeer
    {
        public override int Constructor => -1109531342;

        public int channel_id { get; set; }


        public void ComputeFlags()
        {
        }

        public override void DeserializeBody(BinaryReader br)
        {
            channel_id = br.ReadInt32();
        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            bw.Write(channel_id);
        }
    }
}