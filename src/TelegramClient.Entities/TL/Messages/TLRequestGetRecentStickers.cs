using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    [TLObject(1587647177)]
    public class TLRequestGetRecentStickers : TLMethod
    {
        public override int Constructor => 1587647177;

        public int flags { get; set; }
        public bool attached { get; set; }
        public int hash { get; set; }
        public TLAbsRecentStickers Response { get; set; }


        public void ComputeFlags()
        {
            flags = 0;
            flags = attached ? flags | 1 : flags & ~1;
        }

        public override void DeserializeBody(BinaryReader br)
        {
            flags = br.ReadInt32();
            attached = (flags & 1) != 0;
            hash = br.ReadInt32();
        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ComputeFlags();
            bw.Write(flags);

            bw.Write(hash);
        }

        public override void deserializeResponse(BinaryReader br)
        {
            Response = (TLAbsRecentStickers) ObjectUtils.DeserializeObject(br);
        }
    }
}