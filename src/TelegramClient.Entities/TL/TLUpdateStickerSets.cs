using System.IO;

namespace TelegramClient.Entities.TL
{
    [TLObject(1135492588)]
    public class TLUpdateStickerSets : TLAbsUpdate
    {
        public override int Constructor => 1135492588;


        public void ComputeFlags()
        {
        }

        public override void DeserializeBody(BinaryReader br)
        {
        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
        }
    }
}