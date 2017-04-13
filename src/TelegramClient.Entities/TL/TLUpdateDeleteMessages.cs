using System.IO;

namespace TelegramClient.Entities.TL
{
    [TLObject(-1576161051)]
    public class TLUpdateDeleteMessages : TLAbsUpdate
    {
        public override int Constructor => -1576161051;

        public TLVector<int> messages { get; set; }
        public int pts { get; set; }
        public int pts_count { get; set; }


        public void ComputeFlags()
        {
        }

        public override void DeserializeBody(BinaryReader br)
        {
            messages = ObjectUtils.DeserializeVector<int>(br);
            pts = br.ReadInt32();
            pts_count = br.ReadInt32();
        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ObjectUtils.SerializeObject(messages, bw);
            bw.Write(pts);
            bw.Write(pts_count);
        }
    }
}