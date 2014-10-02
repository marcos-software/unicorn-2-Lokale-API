using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using Unicorn2.Interface;
using Unicorn2.Interface.Exceptions;

namespace SampleLogistiker
{
    [Export(typeof(IPlugin))]
    public class SampleLogistiker : IPlugin
    {
        private Access access;

        #region Plugininformation
        public string Author
        {
            get { return @"marcos-software"; } /* necessary, must not be empty! max 72 chars, allowed chars: a-z, A-Z, 0-9, -, _ */
        }

        public string Version
        {
            get { return @"1.0.0.0"; }
        }

        public string Name
        {
            get { return @"SampleLogistiker"; } /* necessary, must not be empty! max 72 chars, allowed chars: a-z, A-Z, 0-9, -, _ */
        }
        #endregion

        #region Access (Keys, Licence, Install, Features)
        public void SetAccess(Access iAccess)
        {
            access = iAccess;
        }

        public Boolean CheckLicence()
        {
            /* check your licence with the access.LicenceKey and return the state */
            return access.LicenceKey.Equals("test12345");
        }

        public Access GetAccessFlags()
        {
            /* tell us, whitch variables do you need und how we should name it in the gui */
            Access acces = new Access();

            acces.Variables.Add("API Username", new Var { Type = GUIType.Text });
            acces.Variables.Add("API Password", new Var { Type = GUIType.Text });
            acces.Variables.Add("Print on", new Var { Type = GUIType.Dropdown, DropdownValues = new List<String> { "Printer", "PDF", "Nothing" } });
            acces.Variables.Add("UseSandbox", new Var { Type = GUIType.Checkbox });

            return acces;
            /* you can get your user-filled-variables with access.Variables["Api Key"].Value */
        }

        public List<Features> SupportedFeatures
        {
            get { return new List<Features> { Features.Logistiker }; }
        }
        #endregion

        #region Versandklassen
        public List<string> GetVersandklassen()
        {
            throw new NotSupportedException();
        }
        #endregion

        #region Artikel
        public void AddArtikel(List<ResultTask<Artikel>> artikelList)
        {
            throw new NotSupportedException();
        }

        public void SetArtikel(List<ResultTask<Artikel>> artikelList)
        {
            throw new NotSupportedException();
        }

        public void DeleteArtikel(List<ResultTask<Artikel>> artikelList)
        {
            throw new NotSupportedException();
        }
        #endregion

        #region Crossselling
        public void AddCrossselling(Artikel artikel, List<ResultTask<Artikel>> artikelList)
        {
            throw new NotSupportedException();
        }

        public void DeleteCrossselling(Artikel artikel, List<ResultTask<Artikel>> artikelList)
        {
            throw new NotSupportedException();
        }

        #endregion

        #region ArtikelAttribut
        public void AddArtikelAttribut(Artikel artikel, List<ResultTask<ArtikelAttribut>> attributList)
        {
            throw new NotSupportedException();
        }

        public void SetArtikelAttribut(Artikel artikel, List<ResultTask<ArtikelAttribut>> attributList)
        {
            throw new NotSupportedException();
        }

        public void DeleteArtikelAttribut(Artikel artikel, List<ResultTask<ArtikelAttribut>> attributList)
        {
            throw new NotSupportedException();
        }
        #endregion

        #region ArtikelBild
        public void AddArtikelBild(Artikel artikel, List<ResultTask<ArtikelBild>> artikelBildList)
        {
            throw new NotSupportedException();
        }

        public void SetArtikelBild(Artikel artikel, List<ResultTask<ArtikelBild>> artikelBildList)
        {
            throw new NotSupportedException();
        }

        public void DeleteArtikelBild(Artikel artikel, List<ResultTask<ArtikelBild>> artikelBildList)
        {
            throw new NotSupportedException();
        }
        #endregion

        #region Vako
        public void AddVako(Artikel artikel, List<ResultTask<VakoArtikel>> vakoArtikelList)
        {
            throw new NotSupportedException();
        }

        public void SetVako(Artikel artikel, List<ResultTask<VakoArtikel>> vakoArtikelList)
        {
            throw new NotSupportedException();
        }

        public void DeleteVako(Artikel artikel, List<ResultTask<VakoArtikel>> vakoArtikelList)
        {
            throw new NotSupportedException();
        }
        #endregion

        #region VakoBild
        public void AddVakoBild(Artikel artikel, VakoArtikel vakoArtikel, List<ResultTask<ArtikelBild>> artikelBildList)
        {
            throw new NotSupportedException();
        }

        public void SetVakoBild(Artikel artikel, VakoArtikel vakoArtikel, List<ResultTask<ArtikelBild>> artikelBildList)
        {
            throw new NotSupportedException();
        }

        public void DeleteVakoBild(Artikel artikel, VakoArtikel vakoArtikel, List<ResultTask<ArtikelBild>> artikelBildList)
        {
            throw new NotSupportedException();
        }
        #endregion

        #region Kategorien
        public void AddKategorie(List<ResultTask<Kategorie>> kategorieList)
        {
            throw new NotSupportedException();
        }

        public void SetKategorie(List<ResultTask<Kategorie>> kategorieList)
        {
            throw new NotSupportedException();
        }

        public void DeleteKategorie(List<ResultTask<Kategorie>> kategorieList)
        {
            throw new NotSupportedException();
        }

        public List<Kategorie> GetKategorie()
        {
            throw new NotSupportedException();
        }
        #endregion

        #region KategorieLink
        public void AddKategorieLink(Artikel artikel, List<ResultTask<Kategorie>> kategorieList)
        {
            throw new NotSupportedException();
        }

        public void DeleteKategorieLink(Artikel artikel, List<ResultTask<Kategorie>> kategorieList)
        {
            throw new NotSupportedException();
        }
        #endregion

        #region Bestellungen
        public List<Bestellung> GetBestellungen(Bestellstate state, DateTime startdate)
        {
            throw new NotSupportedException();
        }

        public void SetVersendet(List<ResultTask<BestellVersandInfo, VersandInfo, List<ItemError>>> infos)
        {
            /* für jede Bestellung */
            foreach (ResultTask<BestellVersandInfo, VersandInfo, List<ItemError>> task in infos)
            {
                BestellVersandInfo bestellVersandInfo = task.Item;
                /* für jeden Lieferschein */
                foreach (LieferscheinVersandInfo lieferscheinVersandInfo in bestellVersandInfo.LieferscheinVersandInfos)
                {
                    /* für jedes Paket */
                    foreach (VersandInfo versandInfo in lieferscheinVersandInfo.VersandInfos)
                    {
                        if (versandInfo.TryMapVersandDienstleister() == VersandDienstleister.Dhl)
                        {
                            Boolean success = true;
                            String randomTrackingId = new Random(100000000).Next(100000000, 999999999).ToString();

                            versandInfo.TrackingNummer = randomTrackingId;
                            versandInfo.Versanddatum = DateTime.Now;

                            new SampleForm(versandInfo, lieferscheinVersandInfo, bestellVersandInfo).ShowDialog();

                            if (success)
                            {
                                task.OnSuccess(versandInfo);
                            }
                            else
                            {
                                List<ItemError> errorList = new List<ItemError>
                                {
                                    /* Add your errors here */
                                };

                                task.OnError(errorList);
                            }
                        }
                    }
                }
            }
        }

        public void SetBezahlt(List<ResultTask<BestellungsInfo>> infos)
        {
            throw new NotSupportedException();
        }

        public void SetStorno(List<ResultTask<Storno>> infos)
        {
            throw new NotSupportedException();
        }

        public List<Storno> GetStorno(int days)
        {
            throw new NotSupportedException();
        }
        #endregion
    }
}
