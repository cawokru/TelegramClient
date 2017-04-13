using System.IO;

namespace TelegramClient.Entities.TL.Messages
{
    [TLObject(-1551737264)]
    public class TLRequestSetTyping : TLMethod
    {
        public override int Constructor => -1551737264;

        public TLAbsInputPeer peer { get; set; }
        public TLAbsSendMessageAction action { get; set; }
        public bool Response { get; set; }


        public void ComputeFlags()
        {
        }

        public override void DeserializeBody(BinaryReader br)
        {
            peer = (TLAbsInputPeer) ObjectUtils.DeserializeObject(br);
            action = (TLAbsSendMessageAction) ObjectUtils.DeserializeObject(br);
        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ObjectUtils.SerializeObject(peer, bw);
            ObjectUtils.SerializeObject(action, bw);
        }

        public override void deserializeResponse(BinaryReader br)
        {
            Response = BoolUtil.Deserialize(br);
        }
    }
}