using QRCoder;
using System;

namespace Dao.QRGenerator
{
    public class QRGenerator
    {
        public string QrGenerate(Guid token)
        {
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData createQR = qr.CreateQrCode(token.ToString(), QRCodeGenerator.ECCLevel.Q);
            Base64QRCode codeQR = new Base64QRCode(createQR);
            string qrGet = codeQR.GetGraphic(20);
            string qrBase64 = string.Format("data:image/png;base64,{0}", qrGet);
            return qrBase64;
        }
    }
}
