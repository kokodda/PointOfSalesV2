using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace PointOfSalesV2.Common
{
   public class QRImageGenerator
    {
        public static string GenerateQRCode(string text)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(text, QRCodeGenerator.ECCLevel.Q);
            Base64QRCode qrCode = new Base64QRCode(qrCodeData);
            string result = qrCode.GetGraphic(20);
            return result;
        }
    }
}
