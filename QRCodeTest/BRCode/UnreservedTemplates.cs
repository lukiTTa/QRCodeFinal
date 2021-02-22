using QRCodeTest.BRCode.BRCodeEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QRCodeTest.BRCode
{
    public class UnreservedTemplates
    {
        public string Id { get; } = "80";

        public GUI_UT GUI = new GUI_UT();

        public InformacaoArbitrariaArranjo informacaoArbitraria = new InformacaoArbitrariaArranjo();
    }
}
