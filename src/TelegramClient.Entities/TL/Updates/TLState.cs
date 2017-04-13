using System.IO;

namespace TelegramClient.Entities.TL.Updates
{
    [TLObject(-1519637954)]
    public class TLState : TLObject
    {
        public override int Constructor => -1519637954;

        public int pts { get; set; }
        public int qts { get; set; }
        public int date { get; set; }
        public int seq { get; set; }
        public int unread_count { get; set; }


        public void ComputeFlags()
        {
        }

        public override void DeserializeBody(BinaryReader br)
        {
            pts = br.ReadInt32();
            qts = br.ReadInt32();
            date = br.ReadInt32();
            seq = br.ReadInt32();
            unread_count = br.ReadInt32();
        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            bw.Write(pts);
            bw.Write(qts);
            bw.Write(date);
            bw.Write(seq);
            bw.Write(unread_count);
        }
    }
}