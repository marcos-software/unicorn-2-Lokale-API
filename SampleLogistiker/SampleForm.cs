using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using Unicorn2.Interface;

namespace SampleLogistiker
{
    public partial class SampleForm : Form
    {
        private readonly VersandInfo versandInfo;
        private readonly LieferscheinVersandInfo lieferscheinVersandInfo;
        private readonly BestellVersandInfo bestellVersandInfo;
        private BackgroundWorker closeTimer;

        public SampleForm(VersandInfo versandInfo, LieferscheinVersandInfo lieferscheinVersandInfo, BestellVersandInfo bestellVersandInfo)
        {
            this.versandInfo = versandInfo;
            this.lieferscheinVersandInfo = lieferscheinVersandInfo;
            this.bestellVersandInfo = bestellVersandInfo;

            InitializeComponent();

            FillInfo();
            FillLieferadresse();
            FillArticles();
            StartCloseTimer();
        }

        private void FillInfo()
        {
            lblLogistiker.Text = versandInfo.TryMapVersandDienstleister().ToString().ToUpper();
            lblBestellNr.Text = bestellVersandInfo.Bestellung.ShopId;
            lblLieferNr.Text = lieferscheinVersandInfo.LieferscheinNr;
            lblExpress.Text = versandInfo.Express ? "ja" : "nein";
            lblTrackingId.Text = versandInfo.TrackingNummer;
            if (versandInfo.VerwiegePflicht)
            {
                lblVerwiege.Text = "ja";
                lblWaage.Visible = true;
            }
            else
            {
                lblVerwiege.Text = "nein";
                lblWaage.Visible = false;
            }
            txbLieferHinweis.Text = lieferscheinVersandInfo.Hinweis;
            txbPaketHinweis.Text = versandInfo.Hinweis;
        }

        private void FillLieferadresse()
        {
            lblFirma.Text = bestellVersandInfo.Bestellung.Lieferanschrift.Firma;
            lblName.Text = String.Format("{0} {1} {2} {3}",
                bestellVersandInfo.Bestellung.Lieferanschrift.Anrede,
                bestellVersandInfo.Bestellung.Lieferanschrift.Titel,
                bestellVersandInfo.Bestellung.Lieferanschrift.Vorname,
                bestellVersandInfo.Bestellung.Lieferanschrift.Nachname);
            lblStraße.Text = String.Format("{0} {1}",
                bestellVersandInfo.Bestellung.Lieferanschrift.Adresse.Straße,
                bestellVersandInfo.Bestellung.Lieferanschrift.Adresse.Hausnummer);
            lblAdresszusatz.Text = bestellVersandInfo.Bestellung.Lieferanschrift.Adresse.Anmerkung;
            lblPLZOrt.Text = String.Format("{0} {1}",
                bestellVersandInfo.Bestellung.Lieferanschrift.Adresse.PLZ,
                bestellVersandInfo.Bestellung.Lieferanschrift.Adresse.Ort);
            lblLand.Text = bestellVersandInfo.Bestellung.Lieferanschrift.Adresse.Land.Deutsch;
        }

        private void FillArticles()
        {
            dgvArtikel.Rows.Clear();
            foreach (Artikel artikel in lieferscheinVersandInfo.Artikel)
            {
                dgvArtikel.Rows.Add(
                    artikel.ArtikelNummer, 
                    String.Format("{0} - {1}", 
                        artikel.Hersteller.Name, 
                        artikel.Name), 
                    artikel.ArtikelGewicht, 
                    artikel.Preis, 
                    artikel.Taric, 
                    artikel.Herkunftsland, 
                    artikel.Menge);
            }
        }

        private void StartCloseTimer()
        {
            closeTimer = new BackgroundWorker { WorkerSupportsCancellation = true };
            closeTimer.DoWork += StartTimer;
            closeTimer.RunWorkerAsync();
        }

        private void RefreshButtonText(Int16 seconds)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<Int16>(RefreshButtonText), new object[] { seconds });
                return;
            }
            btnClose.Text = String.Format("Dieses Fenster schließt sich in {0} Sekunden\r\noder per Klick jetzt schließen.", seconds);
        }

        private void StartTimer(object sender, DoWorkEventArgs e)
        {
            Int16 i = 30;
            while (i > 0)
            {
                RefreshButtonText(i--);
                Thread.Sleep(1000);
            }
            CloseForm();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void CloseForm(Boolean message = false)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<Boolean>(CloseForm), new object[] { message });
                return;
            }
            if (message) MessageBox.Show("Dieses Fenster schließt sich jetzt.");
            Close();
        }
    }
}
