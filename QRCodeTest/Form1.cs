using QRCoder;
using System.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCodeTest.BRCode;

namespace QRCodeTest
{
    public partial class forms1 : Form
    {
        QRCodeStringGen qstr = new QRCodeStringGen();

        public List <string> Data()
        {
            var singleList = qstr.QRCodeData(
            /*Payload Format Indicator*/              "01",
            /*Merchant Account Information – Cartões*/"12345678901234",
            /*Merchant Account Information - PIX*/    "BR.GOV.BCB.PIX", @"123e4567-e12b-12d1-a456-426655440000",
            /*Merchant Account Information - Outro*/  "BR.COM.OUTRO", "0123456789",
            /*Merchant Category Code*/                "0000",
            /*Transaction Currency*/                  "986",
            /*Transaction Amount*/                    "123.45",
            /*Country Code*/                          "BR",
            /*Merchant Name*/                         "NOME DO RECEBEDOR",
            /*Merchant City*/                         "BRASILIA",
            /*Postal Code*/                           "70074900",
            /*Additional Data Field*/                 "RP12345678-2019",
            /*Unreserved Templates*/                  "BR.COM.OUTRO", "0123.ABCD.3456.WXYZ",
            /*CR16-CCITT*/                            "AD38");
                                             

            return singleList;
        }

        public forms1()
        {
            InitializeComponent();
            txtPayload.Text = Data()[0];
            txtMACards.Text = Data()[1];
            txtMAPix.Text = Data()[2];
            txtMAOutro.Text = Data()[3];
            txtMCCode.Text = Data()[4];
            txtCurrency.Text = Data()[5];
            txtAmount.Text = Data()[6];
            txtCountry.Text = Data()[7];
            txtMName.Text = Data()[8];
            txtMCity.Text = Data()[9];
            txtPostalCode.Text = Data()[10];
            txtAddData.Text = Data()[11];
            txtUnreserved.Text = Data()[12];
            txtCR16.Text = Data()[13];
        }

        public string Code()
        {
            string result = string.Join("", Data());
            
            return result;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(Code(), QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);
            pictureBox.Image = code.GetGraphic(10);
            txtFinalCode.Text = Code();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(txtPayload.Text, QRCodeGenerator.ECCLevel.Q);
            Base64QRCode code = new Base64QRCode(data);
            string qrCodeBase64 = code.GetGraphic(10);
            string fileName = txtFileName.Text;
            string message = "O arquivo foi salvo em: " + AppDomain.CurrentDomain.BaseDirectory;
            string caption = "Arquivo Salvo!";
            File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + fileName + ".txt", qrCodeBase64);
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, caption, buttons);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
