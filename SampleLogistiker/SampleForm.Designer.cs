namespace SampleLogistiker
{
    partial class SampleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblInfoLogistiker = new System.Windows.Forms.Label();
            this.lblInfoBestellNr = new System.Windows.Forms.Label();
            this.lblInfoExpress = new System.Windows.Forms.Label();
            this.lblInfoTrackingId = new System.Windows.Forms.Label();
            this.lblInfoVerwiege = new System.Windows.Forms.Label();
            this.lblWaage = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblLogistiker = new System.Windows.Forms.Label();
            this.lblBestellNr = new System.Windows.Forms.Label();
            this.lblExpress = new System.Windows.Forms.Label();
            this.lblTrackingId = new System.Windows.Forms.Label();
            this.lblVerwiege = new System.Windows.Forms.Label();
            this.lblLieferadresse = new System.Windows.Forms.Label();
            this.lblFirma = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStraße = new System.Windows.Forms.Label();
            this.lblPLZOrt = new System.Windows.Forms.Label();
            this.lblLand = new System.Windows.Forms.Label();
            this.dgvArtikel = new System.Windows.Forms.DataGridView();
            this.ArtNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bezeichnung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gewicht = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WertNetto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TARIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ursprungsland = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Menge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAdresszusatz = new System.Windows.Forms.Label();
            this.lblInfoLieferNr = new System.Windows.Forms.Label();
            this.lblLieferNr = new System.Windows.Forms.Label();
            this.txbLieferHinweis = new System.Windows.Forms.TextBox();
            this.txbPaketHinweis = new System.Windows.Forms.TextBox();
            this.lblInfoLieferHinweis = new System.Windows.Forms.Label();
            this.lblInfoPaketHinweis = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Paketlabel wird erzeugt ...";
            // 
            // lblInfoLogistiker
            // 
            this.lblInfoLogistiker.AutoSize = true;
            this.lblInfoLogistiker.Location = new System.Drawing.Point(22, 51);
            this.lblInfoLogistiker.Name = "lblInfoLogistiker";
            this.lblInfoLogistiker.Size = new System.Drawing.Size(55, 13);
            this.lblInfoLogistiker.TabIndex = 1;
            this.lblInfoLogistiker.Text = "Logistiker:";
            // 
            // lblInfoBestellNr
            // 
            this.lblInfoBestellNr.AutoSize = true;
            this.lblInfoBestellNr.Location = new System.Drawing.Point(22, 74);
            this.lblInfoBestellNr.Name = "lblInfoBestellNr";
            this.lblInfoBestellNr.Size = new System.Drawing.Size(52, 13);
            this.lblInfoBestellNr.TabIndex = 2;
            this.lblInfoBestellNr.Text = "BestellNr:";
            // 
            // lblInfoExpress
            // 
            this.lblInfoExpress.AutoSize = true;
            this.lblInfoExpress.Location = new System.Drawing.Point(22, 123);
            this.lblInfoExpress.Name = "lblInfoExpress";
            this.lblInfoExpress.Size = new System.Drawing.Size(47, 13);
            this.lblInfoExpress.TabIndex = 3;
            this.lblInfoExpress.Text = "Express:";
            // 
            // lblInfoTrackingId
            // 
            this.lblInfoTrackingId.AutoSize = true;
            this.lblInfoTrackingId.Location = new System.Drawing.Point(22, 145);
            this.lblInfoTrackingId.Name = "lblInfoTrackingId";
            this.lblInfoTrackingId.Size = new System.Drawing.Size(61, 13);
            this.lblInfoTrackingId.TabIndex = 4;
            this.lblInfoTrackingId.Text = "TrackingId:";
            // 
            // lblInfoVerwiege
            // 
            this.lblInfoVerwiege.AutoSize = true;
            this.lblInfoVerwiege.Location = new System.Drawing.Point(22, 170);
            this.lblInfoVerwiege.Name = "lblInfoVerwiege";
            this.lblInfoVerwiege.Size = new System.Drawing.Size(131, 13);
            this.lblInfoVerwiege.TabIndex = 5;
            this.lblInfoVerwiege.Text = "Paket hat Verwiegepflicht:";
            // 
            // lblWaage
            // 
            this.lblWaage.AutoSize = true;
            this.lblWaage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblWaage.Location = new System.Drawing.Point(22, 199);
            this.lblWaage.Name = "lblWaage";
            this.lblWaage.Size = new System.Drawing.Size(205, 16);
            this.lblWaage.TabIndex = 6;
            this.lblWaage.Text = "Bitte Paket auf Waage legen";
            this.lblWaage.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(25, 367);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(684, 55);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Dieses Fenster schließt sich in 30 Sekunden";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblLogistiker
            // 
            this.lblLogistiker.AutoSize = true;
            this.lblLogistiker.Location = new System.Drawing.Point(159, 51);
            this.lblLogistiker.Name = "lblLogistiker";
            this.lblLogistiker.Size = new System.Drawing.Size(29, 13);
            this.lblLogistiker.TabIndex = 8;
            this.lblLogistiker.Text = "DHL";
            // 
            // lblBestellNr
            // 
            this.lblBestellNr.AutoSize = true;
            this.lblBestellNr.Location = new System.Drawing.Point(159, 74);
            this.lblBestellNr.Name = "lblBestellNr";
            this.lblBestellNr.Size = new System.Drawing.Size(37, 13);
            this.lblBestellNr.TabIndex = 9;
            this.lblBestellNr.Text = "12345";
            // 
            // lblExpress
            // 
            this.lblExpress.AutoSize = true;
            this.lblExpress.Location = new System.Drawing.Point(159, 123);
            this.lblExpress.Name = "lblExpress";
            this.lblExpress.Size = new System.Drawing.Size(27, 13);
            this.lblExpress.TabIndex = 10;
            this.lblExpress.Text = "nein";
            // 
            // lblTrackingId
            // 
            this.lblTrackingId.AutoSize = true;
            this.lblTrackingId.Location = new System.Drawing.Point(159, 145);
            this.lblTrackingId.Name = "lblTrackingId";
            this.lblTrackingId.Size = new System.Drawing.Size(79, 13);
            this.lblTrackingId.TabIndex = 11;
            this.lblTrackingId.Text = "000000000000";
            // 
            // lblVerwiege
            // 
            this.lblVerwiege.AutoSize = true;
            this.lblVerwiege.Location = new System.Drawing.Point(159, 170);
            this.lblVerwiege.Name = "lblVerwiege";
            this.lblVerwiege.Size = new System.Drawing.Size(27, 13);
            this.lblVerwiege.TabIndex = 12;
            this.lblVerwiege.Text = "nein";
            // 
            // lblLieferadresse
            // 
            this.lblLieferadresse.AutoSize = true;
            this.lblLieferadresse.Location = new System.Drawing.Point(288, 51);
            this.lblLieferadresse.Name = "lblLieferadresse";
            this.lblLieferadresse.Size = new System.Drawing.Size(73, 13);
            this.lblLieferadresse.TabIndex = 15;
            this.lblLieferadresse.Text = "Lieferadresse:";
            // 
            // lblFirma
            // 
            this.lblFirma.AutoSize = true;
            this.lblFirma.Location = new System.Drawing.Point(288, 74);
            this.lblFirma.Name = "lblFirma";
            this.lblFirma.Size = new System.Drawing.Size(190, 13);
            this.lblFirma.TabIndex = 16;
            this.lblFirma.Text = "Musterfirma Testing GmbH und Co. KG";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(288, 98);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(153, 13);
            this.lblName.TabIndex = 17;
            this.lblName.Text = "Herr Prof. Dr. Max Mustermann";
            // 
            // lblStraße
            // 
            this.lblStraße.AutoSize = true;
            this.lblStraße.Location = new System.Drawing.Point(288, 120);
            this.lblStraße.Name = "lblStraße";
            this.lblStraße.Size = new System.Drawing.Size(84, 13);
            this.lblStraße.TabIndex = 21;
            this.lblStraße.Text = "Am Testgelände";
            // 
            // lblPLZOrt
            // 
            this.lblPLZOrt.AutoSize = true;
            this.lblPLZOrt.Location = new System.Drawing.Point(288, 174);
            this.lblPLZOrt.Name = "lblPLZOrt";
            this.lblPLZOrt.Size = new System.Drawing.Size(84, 13);
            this.lblPLZOrt.TabIndex = 23;
            this.lblPLZOrt.Text = "12345 Musterort";
            // 
            // lblLand
            // 
            this.lblLand.AutoSize = true;
            this.lblLand.Location = new System.Drawing.Point(288, 196);
            this.lblLand.Name = "lblLand";
            this.lblLand.Size = new System.Drawing.Size(59, 13);
            this.lblLand.TabIndex = 25;
            this.lblLand.Text = "Musterland";
            // 
            // dgvArtikel
            // 
            this.dgvArtikel.AllowUserToAddRows = false;
            this.dgvArtikel.AllowUserToDeleteRows = false;
            this.dgvArtikel.AllowUserToResizeRows = false;
            this.dgvArtikel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvArtikel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtikel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ArtNr,
            this.Bezeichnung,
            this.Gewicht,
            this.WertNetto,
            this.TARIC,
            this.Ursprungsland,
            this.Menge});
            this.dgvArtikel.Location = new System.Drawing.Point(25, 225);
            this.dgvArtikel.Name = "dgvArtikel";
            this.dgvArtikel.RowHeadersVisible = false;
            this.dgvArtikel.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvArtikel.Size = new System.Drawing.Size(684, 127);
            this.dgvArtikel.TabIndex = 26;
            // 
            // ArtNr
            // 
            this.ArtNr.HeaderText = "ArtNr";
            this.ArtNr.Name = "ArtNr";
            this.ArtNr.ReadOnly = true;
            this.ArtNr.Width = 75;
            // 
            // Bezeichnung
            // 
            this.Bezeichnung.HeaderText = "Bezeichnung";
            this.Bezeichnung.Name = "Bezeichnung";
            this.Bezeichnung.ReadOnly = true;
            this.Bezeichnung.Width = 240;
            // 
            // Gewicht
            // 
            this.Gewicht.HeaderText = "Gewicht";
            this.Gewicht.Name = "Gewicht";
            this.Gewicht.ReadOnly = true;
            this.Gewicht.Width = 60;
            // 
            // WertNetto
            // 
            this.WertNetto.HeaderText = "Wert";
            this.WertNetto.Name = "WertNetto";
            this.WertNetto.ReadOnly = true;
            this.WertNetto.Width = 60;
            // 
            // TARIC
            // 
            this.TARIC.HeaderText = "TARIC";
            this.TARIC.Name = "TARIC";
            this.TARIC.ReadOnly = true;
            this.TARIC.Width = 80;
            // 
            // Ursprungsland
            // 
            this.Ursprungsland.HeaderText = "Ursprungsland";
            this.Ursprungsland.Name = "Ursprungsland";
            this.Ursprungsland.ReadOnly = true;
            // 
            // Menge
            // 
            this.Menge.HeaderText = "Menge";
            this.Menge.Name = "Menge";
            this.Menge.ReadOnly = true;
            this.Menge.Width = 70;
            // 
            // lblAdresszusatz
            // 
            this.lblAdresszusatz.AutoSize = true;
            this.lblAdresszusatz.Location = new System.Drawing.Point(288, 145);
            this.lblAdresszusatz.Name = "lblAdresszusatz";
            this.lblAdresszusatz.Size = new System.Drawing.Size(99, 13);
            this.lblAdresszusatz.TabIndex = 27;
            this.lblAdresszusatz.Text = "2OG links Büro 413";
            // 
            // lblInfoLieferNr
            // 
            this.lblInfoLieferNr.AutoSize = true;
            this.lblInfoLieferNr.Location = new System.Drawing.Point(22, 98);
            this.lblInfoLieferNr.Name = "lblInfoLieferNr";
            this.lblInfoLieferNr.Size = new System.Drawing.Size(78, 13);
            this.lblInfoLieferNr.TabIndex = 28;
            this.lblInfoLieferNr.Text = "LieferscheinNr:";
            // 
            // lblLieferNr
            // 
            this.lblLieferNr.AutoSize = true;
            this.lblLieferNr.Location = new System.Drawing.Point(159, 98);
            this.lblLieferNr.Name = "lblLieferNr";
            this.lblLieferNr.Size = new System.Drawing.Size(52, 13);
            this.lblLieferNr.TabIndex = 29;
            this.lblLieferNr.Text = "12345-01";
            // 
            // txbLieferHinweis
            // 
            this.txbLieferHinweis.Location = new System.Drawing.Point(536, 71);
            this.txbLieferHinweis.Multiline = true;
            this.txbLieferHinweis.Name = "txbLieferHinweis";
            this.txbLieferHinweis.ReadOnly = true;
            this.txbLieferHinweis.Size = new System.Drawing.Size(173, 62);
            this.txbLieferHinweis.TabIndex = 30;
            // 
            // txbPaketHinweis
            // 
            this.txbPaketHinweis.Location = new System.Drawing.Point(536, 153);
            this.txbPaketHinweis.Multiline = true;
            this.txbPaketHinweis.Name = "txbPaketHinweis";
            this.txbPaketHinweis.ReadOnly = true;
            this.txbPaketHinweis.Size = new System.Drawing.Size(173, 62);
            this.txbPaketHinweis.TabIndex = 31;
            // 
            // lblInfoLieferHinweis
            // 
            this.lblInfoLieferHinweis.AutoSize = true;
            this.lblInfoLieferHinweis.Location = new System.Drawing.Point(533, 51);
            this.lblInfoLieferHinweis.Name = "lblInfoLieferHinweis";
            this.lblInfoLieferHinweis.Size = new System.Drawing.Size(107, 13);
            this.lblInfoLieferHinweis.TabIndex = 32;
            this.lblInfoLieferHinweis.Text = "Hinweis Lieferschein:";
            // 
            // lblInfoPaketHinweis
            // 
            this.lblInfoPaketHinweis.AutoSize = true;
            this.lblInfoPaketHinweis.Location = new System.Drawing.Point(533, 136);
            this.lblInfoPaketHinweis.Name = "lblInfoPaketHinweis";
            this.lblInfoPaketHinweis.Size = new System.Drawing.Size(78, 13);
            this.lblInfoPaketHinweis.TabIndex = 33;
            this.lblInfoPaketHinweis.Text = "Hinweis Paket:";
            // 
            // SampleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 449);
            this.Controls.Add(this.lblInfoPaketHinweis);
            this.Controls.Add(this.lblInfoLieferHinweis);
            this.Controls.Add(this.txbPaketHinweis);
            this.Controls.Add(this.txbLieferHinweis);
            this.Controls.Add(this.lblLieferNr);
            this.Controls.Add(this.lblInfoLieferNr);
            this.Controls.Add(this.lblAdresszusatz);
            this.Controls.Add(this.dgvArtikel);
            this.Controls.Add(this.lblLand);
            this.Controls.Add(this.lblPLZOrt);
            this.Controls.Add(this.lblStraße);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblFirma);
            this.Controls.Add(this.lblLieferadresse);
            this.Controls.Add(this.lblVerwiege);
            this.Controls.Add(this.lblTrackingId);
            this.Controls.Add(this.lblExpress);
            this.Controls.Add(this.lblBestellNr);
            this.Controls.Add(this.lblLogistiker);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblWaage);
            this.Controls.Add(this.lblInfoVerwiege);
            this.Controls.Add(this.lblInfoTrackingId);
            this.Controls.Add(this.lblInfoExpress);
            this.Controls.Add(this.lblInfoBestellNr);
            this.Controls.Add(this.lblInfoLogistiker);
            this.Controls.Add(this.label1);
            this.Name = "SampleForm";
            this.Text = "Sample Logistiker Plugin";
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInfoLogistiker;
        private System.Windows.Forms.Label lblInfoBestellNr;
        private System.Windows.Forms.Label lblInfoExpress;
        private System.Windows.Forms.Label lblInfoTrackingId;
        private System.Windows.Forms.Label lblInfoVerwiege;
        private System.Windows.Forms.Label lblWaage;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblLogistiker;
        private System.Windows.Forms.Label lblBestellNr;
        private System.Windows.Forms.Label lblExpress;
        private System.Windows.Forms.Label lblTrackingId;
        private System.Windows.Forms.Label lblVerwiege;
        private System.Windows.Forms.Label lblLieferadresse;
        private System.Windows.Forms.Label lblFirma;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStraße;
        private System.Windows.Forms.Label lblPLZOrt;
        private System.Windows.Forms.Label lblLand;
        private System.Windows.Forms.DataGridView dgvArtikel;
        private System.Windows.Forms.Label lblAdresszusatz;
        private System.Windows.Forms.Label lblInfoLieferNr;
        private System.Windows.Forms.Label lblLieferNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArtNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bezeichnung;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gewicht;
        private System.Windows.Forms.DataGridViewTextBoxColumn WertNetto;
        private System.Windows.Forms.DataGridViewTextBoxColumn TARIC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ursprungsland;
        private System.Windows.Forms.DataGridViewTextBoxColumn Menge;
        private System.Windows.Forms.TextBox txbLieferHinweis;
        private System.Windows.Forms.TextBox txbPaketHinweis;
        private System.Windows.Forms.Label lblInfoLieferHinweis;
        private System.Windows.Forms.Label lblInfoPaketHinweis;
    }
}