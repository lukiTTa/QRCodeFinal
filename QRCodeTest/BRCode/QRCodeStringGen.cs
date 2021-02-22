using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QRCodeTest.BRCode
{
    public class QRCodeStringGen
    {
        PayloadFormatIndicator pfiObj = new PayloadFormatIndicator();
        MerchantAccountInformationCards maicObj = new MerchantAccountInformationCards();
        MerchantAccountInformationPIX maipObj = new MerchantAccountInformationPIX();
        MerchantAccountInformationOutro maioObj = new MerchantAccountInformationOutro();
        MerchantCategoryCode mccObj = new MerchantCategoryCode();
        TransactionCurrency tcObj = new TransactionCurrency();
        TransactionAmount taObj = new TransactionAmount();
        CountryCode ccObj = new CountryCode();
        MerchantName mnObj = new MerchantName();
        MerchantCity mcObj = new MerchantCity();
        PostalCode pcObj = new PostalCode();
        AdditionalDataField adfObj = new AdditionalDataField();
        UnreservedTemplates utObj = new UnreservedTemplates();
        CRC16_CCITT cr16Obj = new CRC16_CCITT();

        public List<string> QRCodeData(string PayloadValue,
                                       string MerchantCardValue,
                                       string GUI_PIX, string ChavePIX,
                                       string GUI_Outro, string IdConta,
                                       string merchantCategoryCode,
                                       string TransactionCurrency,
                                       string TransactionAmount,
                                       string CountryCode,
                                       string MerchantName,
                                       string MerchantCity,
                                       string PostalCode,
                                       string ReferenceLabel,
                                       string GUI_UT, string Info,
                                       string CR16)
        {
            pfiObj.value = PayloadValue;
            maicObj.value = MerchantCardValue;
            maipObj.GUI.value = GUI_PIX;
            maipObj.pixKey.value = ChavePIX;
            maioObj.GUI.value = GUI_Outro;
            maioObj.IdConta.value = IdConta;
            mccObj.value = merchantCategoryCode;
            tcObj.value = TransactionCurrency;
            taObj.value = TransactionAmount;
            ccObj.value = CountryCode;
            mnObj.value = MerchantName;
            mcObj.value = MerchantCity;
            pcObj.value = PostalCode;
            adfObj.referenceLabel.value = ReferenceLabel;
            utObj.GUI.value = GUI_UT;
            utObj.informacaoArbitraria.value = Info;
            cr16Obj.value = CR16;


            List<string> codeData = new List<string>();
            //Payload Format Indicator
            codeData.Add(pfiObj.Id + pfiObj.value.Length.ToString().PadLeft(2, '0') + pfiObj.value);
            //Merchant Account Information – Cartões
            codeData.Add(maicObj.Id + maicObj.value.Length.ToString().PadLeft(2, '0') + maicObj.value);
            //Merchant Account Information - PIX
            string tam = ((maipObj.Id +
                           maipObj.GUI.value + maipObj.GUI.Id +
                           maipObj.pixKey.value + maipObj.pixKey.Id).Length + 2).ToString();
            codeData.Add(maipObj.Id + tam +
                         maipObj.GUI.Id + maipObj.GUI.value.Length.ToString() + maipObj.GUI.value +
                         maipObj.pixKey.Id + maipObj.pixKey.value.Length.ToString() + maipObj.pixKey.value);
            //Merchant Account Information - Outro
            tam = ((maioObj.Id +
                    maioObj.GUI.value + maioObj.GUI.Id +
                    maioObj.IdConta.value + maioObj.IdConta.Id).Length + 2).ToString();
            codeData.Add(maioObj.Id + tam +
                         maioObj.GUI.Id + maioObj.GUI.value.Length.ToString() + maioObj.GUI.value +
                         maioObj.IdConta.Id + maioObj.IdConta.value.Length.ToString() + maioObj.IdConta.value);
            //Merchant Category Code
            codeData.Add(mccObj.Id + mccObj.value.Length.ToString().PadLeft(2, '0') + mccObj.value);
            //Transaction Currency
            codeData.Add(tcObj.Id + tcObj.value.Length.ToString().PadLeft(2, '0') + tcObj.value);
            //Transaction Amount
            codeData.Add(taObj.Id + taObj.value.Length.ToString().PadLeft(2, '0') + taObj.value);
            //Country Code
            codeData.Add(ccObj.Id + ccObj.value.Length.ToString().PadLeft(2, '0') + ccObj.value);
            //Merchant Name
            codeData.Add(mnObj.Id + mnObj.value.Length.ToString().PadLeft(2, '0') + mnObj.value);
            //Merchant City
            codeData.Add(mcObj.Id + mcObj.value.Length.ToString().PadLeft(2, '0') + mcObj.value);
            //Postal Code
            codeData.Add(pcObj.Id + pcObj.value.Length.ToString().PadLeft(2, '0') + pcObj.value);
            //Additional Data Field
            tam = ((adfObj.Id +
                    adfObj.referenceLabel.value + adfObj.referenceLabel.Id).Length).ToString();
            codeData.Add(adfObj.Id + tam +
                         adfObj.referenceLabel.Id + adfObj.referenceLabel.value.Length.ToString() + adfObj.referenceLabel.value);
            //Unreserved Templates 
            tam = ((utObj.Id +
                    utObj.GUI.value + utObj.GUI.Id +
                    utObj.informacaoArbitraria.value + utObj.informacaoArbitraria.Id).Length + 2).ToString();
            codeData.Add(utObj.Id + tam +
                         utObj.GUI.Id + utObj.GUI.value.Length.ToString() + utObj.GUI.value +
                         utObj.informacaoArbitraria.Id + utObj.informacaoArbitraria.value.Length.ToString() + utObj.informacaoArbitraria.value);
            //CRC16-CCITT
            codeData.Add(cr16Obj.Id + cr16Obj.value.Length.ToString().PadLeft(2, '0') + cr16Obj.value);

            return codeData;
        }
    }
}
