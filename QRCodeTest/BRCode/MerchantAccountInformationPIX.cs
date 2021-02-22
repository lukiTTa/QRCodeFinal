using QRCodeTest.BRCode.BRCodeEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QRCodeTest.BRCode
{
    public class MerchantAccountInformationPIX
    {
        public string Id { get; } = "26";
        
        public GUI_PIX GUI = new GUI_PIX();

        public ChavePIX pixKey = new ChavePIX();
    }
}
