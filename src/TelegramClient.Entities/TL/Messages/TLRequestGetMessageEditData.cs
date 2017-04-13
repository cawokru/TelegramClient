using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    [TLObject(-39416522)]
    public class TLRequestGetMessageEditData : TLMethod
    {
        public override int Constructor => -39416522;

        public TLAbsInputPeer peer { get; set; }
        public int id { get; set; }
        public TLMessageEditData Response { get; set; }


        public void ComputeFlags()
        {
        }

        public override void DeserializeBody(BinaryReader br)
        {
            peer = (TLAbsInputPeer) ObjectUtils.DeserializeObject(br);
            id = br.ReadInt32();
        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ObjectUtils.SerializeObject(peer, bw);
            bw.Write(id);
        }

        public override void deserializeResponse(BinaryReader br)
        {
            Response = (TLMessageEditData) ObjectUtils.DeserializeObject(br);
        }
    }
}