
namespace QRCodeTest
{
    partial class forms1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPayload = new System.Windows.Forms.Label();
            this.txtMACards = new System.Windows.Forms.Label();
            this.txtMAPix = new System.Windows.Forms.Label();
            this.txtMAOutro = new System.Windows.Forms.Label();
            this.txtMCCode = new System.Windows.Forms.Label();
            this.txtCurrency = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.Label();
            this.txtMName = new System.Windows.Forms.Label();
            this.txtMCity = new System.Windows.Forms.Label();
            this.txtPostalCode = new System.Windows.Forms.Label();
            this.txtAddData = new System.Windows.Forms.Label();
            this.txtUnreserved = new System.Windows.Forms.Label();
            this.txtCR16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtFinalCode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "QRCode";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(18, 55);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(315, 315);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(18, 376);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(129, 23);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Payload Format Indicator:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(742, 439);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(129, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(648, 406);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(223, 20);
            this.txtFileName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(553, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nome do Arquivo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Merchant Account Cards:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(344, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Merchant Account PIX:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(344, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Merchant Account Others:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(344, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Merchant Category Code:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(344, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Transaction Currency:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(344, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Transaction Amount: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(344, 218);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Country Code:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(344, 240);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Merchant Name:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(344, 262);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Merchant City:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(344, 286);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Postal Code:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(344, 309);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "Additional Data Field:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(344, 332);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(117, 13);
            this.label15.TabIndex = 22;
            this.label15.Text = "Unreserved Templates:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(344, 357);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 13);
            this.label16.TabIndex = 23;
            this.label16.Text = "CR16-CCITT:";
            // 
            // txtPayload
            // 
            this.txtPayload.AutoSize = true;
            this.txtPayload.BackColor = System.Drawing.SystemColors.Window;
            this.txtPayload.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtPayload.Location = new System.Drawing.Point(478, 55);
            this.txtPayload.Name = "txtPayload";
            this.txtPayload.Size = new System.Drawing.Size(0, 13);
            this.txtPayload.TabIndex = 24;
            // 
            // txtMACards
            // 
            this.txtMACards.AutoSize = true;
            this.txtMACards.BackColor = System.Drawing.SystemColors.Window;
            this.txtMACards.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtMACards.Location = new System.Drawing.Point(478, 77);
            this.txtMACards.Name = "txtMACards";
            this.txtMACards.Size = new System.Drawing.Size(0, 13);
            this.txtMACards.TabIndex = 25;
            // 
            // txtMAPix
            // 
            this.txtMAPix.AutoSize = true;
            this.txtMAPix.BackColor = System.Drawing.SystemColors.Window;
            this.txtMAPix.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtMAPix.Location = new System.Drawing.Point(478, 101);
            this.txtMAPix.Name = "txtMAPix";
            this.txtMAPix.Size = new System.Drawing.Size(0, 13);
            this.txtMAPix.TabIndex = 26;
            // 
            // txtMAOutro
            // 
            this.txtMAOutro.AutoSize = true;
            this.txtMAOutro.BackColor = System.Drawing.SystemColors.Window;
            this.txtMAOutro.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtMAOutro.Location = new System.Drawing.Point(478, 125);
            this.txtMAOutro.Name = "txtMAOutro";
            this.txtMAOutro.Size = new System.Drawing.Size(0, 13);
            this.txtMAOutro.TabIndex = 27;
            // 
            // txtMCCode
            // 
            this.txtMCCode.AutoSize = true;
            this.txtMCCode.BackColor = System.Drawing.SystemColors.Window;
            this.txtMCCode.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtMCCode.Location = new System.Drawing.Point(478, 149);
            this.txtMCCode.Name = "txtMCCode";
            this.txtMCCode.Size = new System.Drawing.Size(0, 13);
            this.txtMCCode.TabIndex = 28;
            // 
            // txtCurrency
            // 
            this.txtCurrency.AutoSize = true;
            this.txtCurrency.BackColor = System.Drawing.SystemColors.Window;
            this.txtCurrency.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtCurrency.Location = new System.Drawing.Point(478, 172);
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.Size = new System.Drawing.Size(0, 13);
            this.txtCurrency.TabIndex = 29;
            // 
            // txtAmount
            // 
            this.txtAmount.AutoSize = true;
            this.txtAmount.BackColor = System.Drawing.SystemColors.Window;
            this.txtAmount.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtAmount.Location = new System.Drawing.Point(478, 196);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(0, 13);
            this.txtAmount.TabIndex = 30;
            // 
            // txtCountry
            // 
            this.txtCountry.AutoSize = true;
            this.txtCountry.BackColor = System.Drawing.SystemColors.Window;
            this.txtCountry.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtCountry.Location = new System.Drawing.Point(478, 218);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(0, 13);
            this.txtCountry.TabIndex = 31;
            // 
            // txtMName
            // 
            this.txtMName.AutoSize = true;
            this.txtMName.BackColor = System.Drawing.SystemColors.Window;
            this.txtMName.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtMName.Location = new System.Drawing.Point(478, 240);
            this.txtMName.Name = "txtMName";
            this.txtMName.Size = new System.Drawing.Size(0, 13);
            this.txtMName.TabIndex = 32;
            // 
            // txtMCity
            // 
            this.txtMCity.AutoSize = true;
            this.txtMCity.BackColor = System.Drawing.SystemColors.Window;
            this.txtMCity.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtMCity.Location = new System.Drawing.Point(478, 262);
            this.txtMCity.Name = "txtMCity";
            this.txtMCity.Size = new System.Drawing.Size(0, 13);
            this.txtMCity.TabIndex = 33;
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.AutoSize = true;
            this.txtPostalCode.BackColor = System.Drawing.SystemColors.Window;
            this.txtPostalCode.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtPostalCode.Location = new System.Drawing.Point(478, 286);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(0, 13);
            this.txtPostalCode.TabIndex = 34;
            // 
            // txtAddData
            // 
            this.txtAddData.AutoSize = true;
            this.txtAddData.BackColor = System.Drawing.SystemColors.Window;
            this.txtAddData.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtAddData.Location = new System.Drawing.Point(478, 309);
            this.txtAddData.Name = "txtAddData";
            this.txtAddData.Size = new System.Drawing.Size(0, 13);
            this.txtAddData.TabIndex = 35;
            // 
            // txtUnreserved
            // 
            this.txtUnreserved.AutoSize = true;
            this.txtUnreserved.BackColor = System.Drawing.SystemColors.Window;
            this.txtUnreserved.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtUnreserved.Location = new System.Drawing.Point(478, 332);
            this.txtUnreserved.Name = "txtUnreserved";
            this.txtUnreserved.Size = new System.Drawing.Size(0, 13);
            this.txtUnreserved.TabIndex = 36;
            // 
            // txtCR16
            // 
            this.txtCR16.AutoSize = true;
            this.txtCR16.BackColor = System.Drawing.SystemColors.Window;
            this.txtCR16.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtCR16.Location = new System.Drawing.Point(478, 357);
            this.txtCR16.Name = "txtCR16";
            this.txtCR16.Size = new System.Drawing.Size(0, 13);
            this.txtCR16.TabIndex = 37;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(18, 406);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 13);
            this.label17.TabIndex = 38;
            this.label17.Text = "Código Final:";
            // 
            // txtFinalCode
            // 
            this.txtFinalCode.Location = new System.Drawing.Point(92, 403);
            this.txtFinalCode.Multiline = true;
            this.txtFinalCode.Name = "txtFinalCode";
            this.txtFinalCode.ReadOnly = true;
            this.txtFinalCode.Size = new System.Drawing.Size(455, 59);
            this.txtFinalCode.TabIndex = 40;
            this.txtFinalCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // forms1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(884, 474);
            this.Controls.Add(this.txtFinalCode);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtCR16);
            this.Controls.Add(this.txtUnreserved);
            this.Controls.Add(this.txtAddData);
            this.Controls.Add(this.txtPostalCode);
            this.Controls.Add(this.txtMCity);
            this.Controls.Add(this.txtMName);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtCurrency);
            this.Controls.Add(this.txtMCCode);
            this.Controls.Add(this.txtMAOutro);
            this.Controls.Add(this.txtMAPix);
            this.Controls.Add(this.txtMACards);
            this.Controls.Add(this.txtPayload);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.label1);
            this.Name = "forms1";
            this.Text = "QRCode Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label txtPayload;
        private System.Windows.Forms.Label txtMACards;
        private System.Windows.Forms.Label txtMAPix;
        private System.Windows.Forms.Label txtMAOutro;
        private System.Windows.Forms.Label txtMCCode;
        private System.Windows.Forms.Label txtCurrency;
        private System.Windows.Forms.Label txtAmount;
        private System.Windows.Forms.Label txtCountry;
        private System.Windows.Forms.Label txtMName;
        private System.Windows.Forms.Label txtMCity;
        private System.Windows.Forms.Label txtPostalCode;
        private System.Windows.Forms.Label txtAddData;
        private System.Windows.Forms.Label txtUnreserved;
        private System.Windows.Forms.Label txtCR16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtFinalCode;
    }
}

