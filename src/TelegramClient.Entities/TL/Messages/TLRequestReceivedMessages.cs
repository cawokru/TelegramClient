using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    [TLObject(94983360)]
    public class TLRequestReceivedMessages : TLMethod
    {
        public override int Constructor => 94983360;

        public int max_id { get; set; }
        public TLVector<TLReceivedNotifyMessage> Response { get; set; }


        public void ComputeFlags()
        {
        }

        public override void DeserializeBody(BinaryReader br)
        {
            max_id = br.ReadInt32();
        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            bw.Write(max_id);
        }

        public override void deserializeResponse(BinaryReader br)
        {
            Response = ObjectUtils.DeserializeVector<TLReceivedNotifyMessage>(br);
        }
    }
}