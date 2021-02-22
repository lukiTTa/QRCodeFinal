using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QRCodeTest.BRCode
{
    public class QRCodeEMV
    {
        public static PayloadFormatIndicator payloadFormatIndicator { get; set; }
        public static MerchantAccountInformationCards merchantAccountInformationCards { get; set; }
        public static MerchantAccountInformationPIX merchantAccountInformationPIX { get; set; }
        public static MerchantAccountInformationOutro merchantAccountInformationOutro { get; set; }
        public static MerchantCategoryCode merchantCategoryCode { get; set; }
        public static TransactionCurrency transactionCurrency { get; set; }
        public static TransactionAmount transactionAmount { get; set; }
        public static CountryCode countryCode { get; set; }
        public static MerchantName merchantName { get; set; }
        public static MerchantCity merchantCity { get; set; }
        public static PostalCode postalCode { get; set; }
        public static AdditionalDataField additionalDataField { get; set; }
        public static UnreservedTemplates unreservedTemplates { get; set; }
        public static CRC16_CCITT CRC16 { get; set; }
    }
}
