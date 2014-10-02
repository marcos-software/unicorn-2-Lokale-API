using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using Unicorn2.Interface;
using Unicorn2.Interface.Exceptions;

namespace Unicorn2.Marketplace.Api.Lokal.Sample.Standard
{
    [Export(typeof(IPlugin))]
    public class SamplePlugin : IPlugin
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
            get { return @"SamplePlugin"; } /* necessary, must not be empty! max 72 chars, allowed chars: a-z, A-Z, 0-9, -, _ */
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

            acces.Variables.Add("Api Key", new Var { Type = GUIType.Text });
            acces.Variables.Add("Merchant ID", new Var { Type = GUIType.Text });
            acces.Variables.Add("Method", new Var { Type = GUIType.Dropdown, DropdownValues = new List<String> { "cURL", "XML" } });
            acces.Variables.Add("ShowAGB", new Var { Type = GUIType.Checkbox });

            return acces;
            /* you can get your user-filled-variables with access.Variables["Api Key"].Value */
        }

        public List<Features> SupportedFeatures
        {
            get
            {
                return new List<Features>
                {
                    Features.Bilder,
                    Features.Erscheinungsdatum,
                    Features.NativeVako,
                    Features.SupportsHtml,
                    Features.TeilVersand,
                    Features.VakoBilder,
                    Features.Versandklassen
                };
            }
        }
        #endregion

        #region Versandklassen
        public List<string> GetVersandklassen()
        {
            return new List<string>
            {
                "Paket National",
                "Paket International",
                "Kurier"
            };
        }
        #endregion

        #region Artikel
        public void AddArtikel(List<ResultTask<Artikel>> artikelList)
        {
            foreach (ResultTask<Artikel> task in artikelList)
            {
                Artikel artikel = task.Item;
                Boolean success = true;

                if (success)
                {
                    task.OnSuccess("yourArticleIdOnMarketplace_" + (new Random().Next(1000, 9999)));
                }
                else
                {
                    /* Example how to handle errors */
                    List<ItemError> errorList = new List<ItemError>
                    {
                        ItemError.Artikel.Allgemeines.ArtNoIsNotUnique,
                        ItemError.Artikel.Allgemeines.EanNotValid,
                        ItemError.Artikel.Allgemeines.ArticleNotSellable,
                        ItemError.Sonstiges.Authentifizierung.MerchantHasntRights
                    };

                    task.OnError(errorList);
                }
            }
        }

        public void SetArtikel(List<ResultTask<Artikel>> artikelList)
        {
            foreach (ResultTask<Artikel> task in artikelList)
            {
                Artikel artikel = task.Item;
                Boolean success = true;

                /* you can identify the article with artikel.ShopId */

                if (success)
                {
                    task.OnSuccess(null);
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

        public void DeleteArtikel(List<ResultTask<Artikel>> artikelList)
        {
            foreach (ResultTask<Artikel> task in artikelList)
            {
                Artikel artikel = task.Item;
                Boolean success = true;

                /* you can identify the article with artikel.ShopId */

                if (success)
                {
                    task.OnSuccess(null);
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
        #endregion

        #region Crossselling
        public void AddCrossselling(Artikel artikel, List<ResultTask<Artikel>> artikelList)
        {
            foreach (ResultTask<Artikel> task in artikelList)
            {
                Artikel crossSellingArtikel = task.Item;
                Boolean success = true;

                /* artikel = article to add crossselling to
                    * crossSellingArtikel = article to connect with
                    */

                if (success)
                {
                    task.OnSuccess("yourCrossSellingIdOnMarketplace_" + (new Random().Next(1000, 9999)));
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

        public void DeleteCrossselling(Artikel artikel, List<ResultTask<Artikel>> artikelList)
        {
            foreach (ResultTask<Artikel> task in artikelList)
            {
                Artikel crossSellingArtikel = task.Item;
                Boolean success = true;

                /* artikel = article to remove crossselling from
                    * crossSellingArtikel = article to disconnect to
                    * you can identify the crossselling with crossSellingArtikel.ShopId
                    */

                if (success)
                {
                    task.OnSuccess(null);
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
        #endregion

        #region ArtikelAttribut
        public void AddArtikelAttribut(Artikel artikel, List<ResultTask<ArtikelAttribut>> attributList)
        {
            foreach (ResultTask<ArtikelAttribut> task in attributList)
            {
                ArtikelAttribut artikelAttribut = task.Item;
                Boolean success = true;

                /* artikel = article to add attribut to */

                if (success)
                {
                    task.OnSuccess("yourAttributIdOnMarketplace_" + (new Random().Next(1000, 9999)));
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

        public void SetArtikelAttribut(Artikel artikel, List<ResultTask<ArtikelAttribut>> attributList)
        {
            foreach (ResultTask<ArtikelAttribut> task in attributList)
            {
                ArtikelAttribut artikelAttribut = task.Item;
                Boolean success = true;

                /* you can identify the Artikelattribut with artikelAttribut.ShopId */

                if (success)
                {
                    task.OnSuccess(null);
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

        public void DeleteArtikelAttribut(Artikel artikel, List<ResultTask<ArtikelAttribut>> attributList)
        {
            foreach (ResultTask<ArtikelAttribut> task in attributList)
            {
                ArtikelAttribut artikelAttribut = task.Item;
                Boolean success = true;

                /* you can identify the Artikelattribut with artikelAttribut.ShopId */

                if (success)
                {
                    task.OnSuccess(null);
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
        #endregion

        #region ArtikelBild
        public void AddArtikelBild(Artikel artikel, List<ResultTask<ArtikelBild>> artikelBildList)
        {
            foreach (ResultTask<ArtikelBild> task in artikelBildList)
            {
                ArtikelBild artikelBild = task.Item;
                Boolean success = true;

                /* artikel = article to add the picture to */

                if (success)
                {
                    task.OnSuccess("yourPictureIdOnMarketplace_" + (new Random().Next(1000, 9999)));
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

        public void SetArtikelBild(Artikel artikel, List<ResultTask<ArtikelBild>> artikelBildList)
        {
            foreach (ResultTask<ArtikelBild> task in artikelBildList)
            {
                ArtikelBild artikelBild = task.Item;
                Boolean success = true;

                /* you can identify the ArtikelBild with artikelBild.ShopId */

                if (success)
                {
                    task.OnSuccess(null);
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

        public void DeleteArtikelBild(Artikel artikel, List<ResultTask<ArtikelBild>> artikelBildList)
        {
            foreach (ResultTask<ArtikelBild> task in artikelBildList)
            {
                ArtikelBild artikelBild = task.Item;
                Boolean success = true;

                /* you can identify the ArtikelBild with artikelBild.ShopId */

                if (success)
                {
                    task.OnSuccess(null);
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
        #endregion

        #region Vako
        public void AddVako(Artikel artikel, List<ResultTask<VakoArtikel>> vakoArtikelList)
        {
            foreach (ResultTask<VakoArtikel> task in vakoArtikelList)
            {
                VakoArtikel vakoArtikel = task.Item;
                Boolean success = true;

                /* artikel = article to add the vakoartikel to */

                if (success)
                {
                    task.OnSuccess("yourVakoIdOnMarketplace_" + (new Random().Next(1000, 9999)));
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

        public void SetVako(Artikel artikel, List<ResultTask<VakoArtikel>> vakoArtikelList)
        {
            foreach (ResultTask<VakoArtikel> task in vakoArtikelList)
            {
                VakoArtikel vakoArtikel = task.Item;
                Boolean success = true;

                /* you can identify the VakoArtikel with vakoArtikel.ShopId */

                if (success)
                {
                    task.OnSuccess(null);
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

        public void DeleteVako(Artikel artikel, List<ResultTask<VakoArtikel>> vakoArtikelList)
        {
            foreach (ResultTask<VakoArtikel> task in vakoArtikelList)
            {
                VakoArtikel vakoArtikel = task.Item;
                Boolean success = true;

                /* you can identify the VakoArtikel with vakoArtikel.ShopId */

                if (success)
                {
                    task.OnSuccess(null);
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
        #endregion

        #region VakoBild
        public void AddVakoBild(Artikel artikel, VakoArtikel vakoArtikel, List<ResultTask<ArtikelBild>> artikelBildList)
        {
            foreach (ResultTask<ArtikelBild> task in artikelBildList)
            {
                ArtikelBild artikelBild = task.Item;
                Boolean success = true;

                /* vakoArtikel = VakoArtikel to add the artikelBild to
                    * artikel = Artikel the vako is from */

                if (success)
                {
                    task.OnSuccess("yourVakoBildIdOnMarketplace_" + (new Random().Next(1000, 9999)));
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

        public void SetVakoBild(Artikel artikel, VakoArtikel vakoArtikel, List<ResultTask<ArtikelBild>> artikelBildList)
        {
            foreach (ResultTask<ArtikelBild> task in artikelBildList)
            {
                ArtikelBild artikelBild = task.Item;
                Boolean success = true;

                /* you can identify the ArtikelBild with artikelBild.ShopId */

                if (success)
                {
                    task.OnSuccess(null);
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

        public void DeleteVakoBild(Artikel artikel, VakoArtikel vakoArtikel, List<ResultTask<ArtikelBild>> artikelBildList)
        {
            foreach (ResultTask<ArtikelBild> task in artikelBildList)
            {
                ArtikelBild artikelBild = task.Item;
                Boolean success = true;

                /* you can identify the ArtikelBild with artikelBild.ShopId */

                if (success)
                {
                    task.OnSuccess(null);
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
        #endregion

        #region Kategorien
        public void AddKategorie(List<ResultTask<Kategorie>> kategorieList)
        {
            foreach (ResultTask<Kategorie> task in kategorieList)
            {
                Kategorie kategorie = task.Item;
                Boolean success = true;

                if (success)
                {
                    task.OnSuccess("yourCategoryIdOnMarketplace_" + (new Random().Next(1000, 9999)));
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

        public void SetKategorie(List<ResultTask<Kategorie>> kategorieList)
        {
            foreach (ResultTask<Kategorie> task in kategorieList)
            {
                Kategorie kategorie = task.Item;
                Boolean success = true;

                /* you can identify the category with kategorie.ShopId */

                if (success)
                {
                    task.OnSuccess(null);
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

        public void DeleteKategorie(List<ResultTask<Kategorie>> kategorieList)
        {
            foreach (ResultTask<Kategorie> task in kategorieList)
            {
                Kategorie kategorie = task.Item;
                Boolean success = true;

                /* you can identify the category with kategorie.ShopId */

                if (success)
                {
                    task.OnSuccess(null);
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

        public List<Kategorie> GetKategorie()
        {
            /* return a List<Kategorie> with all shopcategories of the merchant */
            List<Kategorie> shopCategories = new List<Kategorie>();
            return shopCategories;
        }
        #endregion

        #region KategorieLink
        public void AddKategorieLink(Artikel artikel, List<ResultTask<Kategorie>> kategorieList)
        {
            foreach (ResultTask<Kategorie> task in kategorieList)
            {
                Kategorie kategorie = task.Item;
                Boolean success = true;

                /* artikel = Artikel to link the kategorie with */

                if (success)
                {
                    task.OnSuccess("yourLinkIdOnMarketplace_" + (new Random().Next(1000, 9999)));
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

        public void DeleteKategorieLink(Artikel artikel, List<ResultTask<Kategorie>> kategorieList)
        {
            foreach (ResultTask<Kategorie> task in kategorieList)
            {
                Kategorie kategorie = task.Item;
                Boolean success = false;

                /* artikel = Artikel to delete the kategorie link */

                if (success)
                {
                    task.OnSuccess(null);
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
        #endregion

        #region Bestellungen
        public List<Bestellung> GetBestellungen(Bestellstate state, DateTime startdate)
        {
            List<Bestellung> bestellungen = new List<Bestellung>();

            /*
                * get orders, specified by following options
                * - state     == Bestellstate.Open       <= get open orders     (all orders that are not sent and not cancelled)
                * - state     == Bestellstate.Editable   <= get editable orders (if your marketplace separates between pending and editable orders, get all editable orders (without the pendings))     
                * - startdate == get orders with state option and date between startdate und now  
                * 
                * store the orders in bestellungen
                *
                * --------------
                * e.g.:
                *              
                * foreach(MarketplaceOrder marketplaceOrder in getMarketplaceOrders(state, startdate))
                * {
                *      Bestellung bestellung = new Bestellung();
                *      ...
                *      bestellungen.Add(bestellung);
                * }              
                */

            bestellungen.Add(new Bestellung
            {
                ShopId = "sampleOrderId_" + (new Random().Next(1000, 9999)),
                Gesammtkosten = 9.37,
                Versandkosten = 4.99,
                VersandDienstleister = "DHL National",
                Lieferdatum = DateTime.Now.AddDays(4),
                Zahlungsart = Zahlungsart.Nachnahme,
                Waehrung = Waehrung.EURO,
                Status = Status.EingegangenUndFreigegeben,
                Kundenbemerkung = "Please send the products as fast as you can! Thank you, regards, your buyer",
                Bestelldatum = DateTime.Now,

                Kunde = new Kunde
                {
                    Kundennummer = "sampleClientId_" + (new Random().Next(1000, 9999)),
                    Firma = "Die Testfirma GmbH",
                    FirmenZusatz = "wir testen das!",
                    Titel = "Prof. Dr.",
                    Vorname = "Testina",
                    Nachname = "Testerin",
                    Geschlecht = Geschlecht.Weiblich,
                    Zhd = "Hr. Einkäufer (Buchhaltung)",
                    UStId = "DE 123456789",
                    Email = "t.testerin@testfirma.de_" + (new Random().Next(1000, 9999)),
                    Telefon = "012 / 345 678 - 9",
                    Fax = "012 / 987 654 - 3",
                    Mobil = "0170 123 456",
                    Geburtstag = "07.07.1977",

                    Adresse = new Adresse
                    {
                        Straße = "Am Testgelände",
                        Hausnummer = "12a",
                        Anmerkung = "Gebäudekomplex \"Anton\"",
                        PLZ = "12345",
                        Ort = "Testort",
                        Bundesland = "Nordrhein-Westfalen",
                        Land = Land.DE
                    }
                },

                Lieferanschrift = new Anschrift
                {
                    Firma = "Lagerfirma UG",
                    FirmenZusatz = "denn lagern ist Leidenschaft!",
                    Titel = "Dipl.-Ing.",
                    Vorname = "Ludwig",
                    Nachname = "Lagerist",
                    Geschlecht = Geschlecht.Männlich,
                    Email = "l.lagerist@lagerfirma.de_" + (new Random().Next(1000, 9999)),
                    Telefon = "098 / 765 432 - 1",
                    Fax = "098 / 123 456 - 7",
                    Mobil = "0151 654 321",

                    Adresse = new Adresse
                    {
                        Straße = "Lagerstraße",
                        Hausnummer = "211",
                        Anmerkung = "Tor 4",
                        PLZ = "5432",
                        Ort = "Lagerstadt",
                        Bundesland = "Tirol",
                        Land = Land.AT
                    }
                },

                Gutscheine = new List<Gutschein>
            {
                new Gutschein
                {
                    GutscheinNummer = "sampleCouponId_" + (new Random().Next(1000, 9999)),
                    Rabatt = 9.99,
                    Code = "sampleCouponCode_" + (new Random().Next(1000, 9999)),
                    Bemerkung = "unicorn 2 is great - coupon!"
                }
            },

                Artikel = new List<Artikel>
            {
                new Artikel
                {
                    ShopId = "yourArticleIdOnMarketplace_1", // the returned articleId from function AddArtikel(List<Artikel> artikelList) 
                    ArtikelNummer = "productArtNo_1",
                    Name = "sampleProduct_1",
                    Hinweis = "with gift package",
                    Menge = 2,
                    Preis = 2.69, // Brutto (with tax included)
                    GesammtPreis = 5.38,
                    MwSt = Steuer.MwSt7
                },

                new Artikel
                {
                    ShopId = "yourArticleIdOnMarketplace_2",
                    ArtikelNummer = "productArtNo_2",
                    Name = "sampleProduct_2 with variations Color: blue Size: XXL",
                    Menge = 1,
                    Preis = 8.99,
                    GesammtPreis = 8.99,
                    MwSt = Steuer.MwSt19,

                    VakoArtikel = new List<VakoArtikel>
                    {
                        new VakoArtikel
                        {
                            ShopId = "yourVariationIdOnMarketplace", // the returned variantId from function addArticle($article) on adding this explicit variation 
                            Eigenschaften = new List<WertEigenschaft>
                            {
                                new WertEigenschaft
                                {
                                    Name = "Color",
                                    Wert = new Eigenschaftswert
                                    {
                                        Wert = "blue",
                                        Aktiv = true
                                    }
                                },

                                new WertEigenschaft
                                {
                                    Name = "Size",
                                    Wert = new Eigenschaftswert
                                    {
                                        Wert = "XXL",
                                        Aktiv = true
                                    }
                                }
                            }
                        }
                    }
                }
            }
            });

            bestellungen.Add(new Bestellung
            {
                ShopId = "sampleOrderId_2_" + (new Random().Next(1000, 9999)),
                Gesammtkosten = 34.95,
                Versandkosten = 14.99,
                VersandDienstleister = "DPD Kurier",
                Zahlungsart = Zahlungsart.Vorkasse,
                Waehrung = Waehrung.EURO,
                Status = Status.EingegangenUndFreigegeben,
                Kundenbemerkung = "Bitte schnellstmöglich versenden, Danke!",
                Bestelldatum = DateTime.Now,

                Kunde = new Kunde
                {
                    Kundennummer = "sampleClientId_2_" + (new Random().Next(1000, 9999)),
                    Vorname = "Arno",
                    Nachname = "Nym",
                    Geschlecht = Geschlecht.Männlich,
                    Email = "arno.nym@mail.de_" + (new Random().Next(1000, 9999)),

                    Adresse = new Adresse
                    {
                        Straße = "Am geheimen Weg",
                        Hausnummer = "1",
                        PLZ = "13373",
                        Ort = "Geheim",
                        Land = Land.DE
                    }
                },

                Lieferanschrift = new Anschrift
                {
                    Vorname = "Arno",
                    Nachname = "Nym",
                    Geschlecht = Geschlecht.Männlich,
                    Email = "arno.nym@mail.de_" + (new Random().Next(1000, 9999)),

                    Adresse = new Adresse
                    {
                        Straße = "Am geheimen Weg",
                        Hausnummer = "1",
                        Anmerkung = "Tor 4",
                        PLZ = "13373",
                        Ort = "Geheim",
                        Land = Land.DE
                    }
                },

                Artikel = new List<Artikel>
            {
                new Artikel
                {
                    ShopId = "yourArticleIdOnMarketplace_1_2",
                    ArtikelNummer = "productArtNo_1_2",
                    Name = "sampleProduct_1_2",
                    Hinweis = "with gift package",
                    Menge = 4,
                    Preis = 4.99,
                    GesammtPreis = 19.96,
                    MwSt = Steuer.MwSt10P7
                }
            }
            });

            return bestellungen;
        }

        public void SetVersendet(List<ResultTask<BestellVersandInfo, VersandInfo, List<ItemError>>> infos)
        {
            /* für jede Bestellung */
            foreach (ResultTask<BestellVersandInfo, VersandInfo, List<ItemError>> task in infos)
            {
                BestellVersandInfo bestellVersandInfo = task.Item;

                /* für jeden lieferschein */
                foreach (LieferscheinVersandInfo lieferscheinVersandInfo in bestellVersandInfo.LieferscheinVersandInfos)
                {
                    /* für jedes paket */
                    foreach (VersandInfo versandInfo in lieferscheinVersandInfo.VersandInfos)
                    {
                        String BestellNr = bestellVersandInfo.Bestellung.ShopId;
                        Boolean success = true;

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

        public void SetBezahlt(List<ResultTask<BestellungsInfo>> infos)
        {
            foreach (ResultTask<BestellungsInfo> task in infos)
            {
                BestellungsInfo info = task.Item;
                String BestellNr = info.Bestellung.ShopId;
                Boolean success = true;

                if (success)
                {
                    task.OnSuccess(null);
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

        public void SetStorno(List<ResultTask<Storno>> infos)
        {
            foreach (ResultTask<Storno> task in infos)
            {
                Storno storno = task.Item;
                String BestellNr = storno.Bestellung.ShopId;
                Boolean success = true;

                if (success)
                {
                    task.OnSuccess(null);
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

        public List<Storno> GetStorno(int days)
        {
            DateTime startdate = DateTime.Now.AddDays((days * -1));
            List<Storno> cancellations = new List<Storno>();

            /*
                * get cancelled orders since startdate
                * 
                * store the orders in cancellations
                *
                * --------------
                * e.g.:
                *              
                * foreach(MarketplaceOrder marketplaceOrder in getMarketplaceOrders(State.Cancelled, startdate))
                * {
                *      cancellations.Add(CreateStorno(marketplaceOrder.marketplaceId, marketplaceOrder.reason));
                * }              
                */

            cancellations.Add(CreateStorno("sampleOrderId_1", "Defekt (Beschädigt)"));

            return cancellations;
        }

        private Storno CreateStorno(string shopId, string bemerkung)
        {
            Bestellung bestellung = new Bestellung();
            bestellung.ShopId = shopId;
            bestellung.Status = Status.Storniert;

            Storno storno = new Storno(bestellung);
            storno.Bemerkung = bemerkung;

            return storno;
        }
        #endregion
    }
}
