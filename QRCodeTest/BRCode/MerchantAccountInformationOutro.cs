using QRCodeTest.BRCode.BRCodeEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QRCodeTest.BRCode
{
    public class MerchantAccountInformationOutro
    {
        public string Id { get; } = "27";

        public GUI_Outro GUI = new GUI_Outro();

        public IdConta IdConta = new IdConta();
    }
}
