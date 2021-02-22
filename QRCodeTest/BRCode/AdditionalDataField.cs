using QRCodeTest.BRCode.BRCodeEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QRCodeTest.BRCode
{
    public class AdditionalDataField
    {
        public string Id { get; } = "62";

        public ReferenceLabel referenceLabel = new ReferenceLabel();
    }
}
