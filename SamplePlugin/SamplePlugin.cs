using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using Unicorn2.Interface;

namespace SamplePlugin
{
    [Export(typeof (IPlugin))]
    public class SamplePlugin : IPlugin
    {
        private Access access;

        #region Plugininformation

        public string Author
        {
            get { return @"marcos-software"; } //necessary, must not be empty! max 72 chars, allowed chars: a-z, A-Z, 0-9, -, _
        }

        public string Version
        {
            get { return @"1.0.0.0"; }
        }

        public string Name
        {
            get { return @"SamplePlugin"; } //necessary, must not be empty! max 72 chars, allowed chars: a-z, A-Z, 0-9, -, _
        }

        #endregion

        #region Access (Keys, Licence, Install)

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

            acces.Variables.Add("Api Key", new Var { Type = GUIType.Text});
            acces.Variables.Add("Merchant ID", new Var { Type = GUIType.Text });
            acces.Variables.Add("Method", new Var { Type = GUIType.Dropdown, DropdownValues = new List<String> {"cURL", "XML"}});
            acces.Variables.Add("ShowAGB", new Var { Type = GUIType.Checkbox});

            return acces;
            /* you can reach your filled variables by 
             * access.Variables["Api Key"].Value      
             */
        }

        #endregion

        #region Versandklassen

        public List<string> GetVersandklassen()
        {
            List<string> versandklassen = new List<string>
            {
                "Paket National",
                "Paket International",
                "Kurier"
            };

            return versandklassen;
        }

        #endregion

        #region Artikel

        public List<Artikel> AddArtikel(List<Artikel> artikelList)
        {
            foreach (Artikel artikel in artikelList)
            {
                /* add article to your marketplace:
                 * if it fails set Success to false
                 * else set Success to true and store the returned ID in PluginId
                 */

                artikel.Success = true;
                artikel.PluginId = "yourArticleIdOnMarketplace_" + (new Random().Next(1000, 9999));

                foreach (VakoArtikel vakoArtikel in artikel.VakoArtikel)
                {
                    foreach (WertEigenschaft eigenschaft in vakoArtikel.Eigenschaften)
                    {
                        /* add variation of this article to your marketplace:
                         * store the returned ID in PluginId
                         */
                    }

                    vakoArtikel.PluginId = "yourVariationIdOnMarketplace_" + (new Random().Next(1000, 9999));
                }
            }
            return artikelList;
        }

        public List<Artikel> SetArtikel(List<Artikel> artikelList)
        {
            foreach (Artikel artikel in artikelList)
            {
                /* update article in your marketplace:
                 * if it fails set Success to false
                 * else set Success to true
                 * you can identify the artikel by ShopId
                 */

                artikel.Success = true;
            }
            return artikelList;
        }

        public List<Artikel> DeleteArtikel(List<Artikel> artikelList)
        {
            foreach (Artikel artikel in artikelList)
            {
                /* delete article in your marketplace:
                 * if it fails set Success to false
                 * else set Success to true
                 * you can identify the artikel by ShopId
                 */

                artikel.Success = true;
            }
            return artikelList;
        }

        #endregion

        #region Kategorien

        public List<Kategorie> AddKategorie(List<Kategorie> kategorieList)
        {
            foreach (Kategorie kategorie in kategorieList)
            {
                /* add category to your marketplace:
                 * if it fails set Success to false
                 * else set Success to true and store the returned ID in PluginId
                 */

                kategorie.Success = true;
                kategorie.PluginId = "yourCategoryIdOnMarketplace_" + (new Random().Next(1000, 9999));
            }
            return kategorieList;
        }

        public List<Kategorie> SetKategorie(List<Kategorie> kategorieList)
        {
            foreach (Kategorie kategorie in kategorieList)
            {
                /* update category in your marketplace:
                 * if it fails set Success to false
                 * else set Success to true
                 * you can identify the kategorie by ShopId
                 */

                kategorie.Success = true;
            }
            return kategorieList;
        }

        public List<Kategorie> DeleteKategorie(List<Kategorie> kategorieList)
        {
            foreach (Kategorie kategorie in kategorieList)
            {
                /* delete category in your marketplace:
                 * if it fails set Success to false
                 * else set Success to true
                 * you can identify the kategorie by ShopId
                 */

                kategorie.Success = true;
            }
            return kategorieList;
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

        public List<BestellVersandInfo> SetVersendet(List<BestellVersandInfo> sendings)
        {
            foreach (BestellVersandInfo sending in sendings)
            {
                /* set order sending to your marketplace:
                 * if it fails set Success to false
                 * else set Success to true
                 * you can identify the order by sending.Bestellung.ShopId
                 */

                sending.Success = true;
            }
            return sendings;
        }

        public List<BestellVersandInfo> SetBezahlt(List<BestellVersandInfo> payments)
        {
            foreach (BestellVersandInfo payment in payments)
            {
                /* set order payment to your marketplace:
                 * if it fails set Success to false
                 * else set Success to true
                 * you can identify the order by payment.Bestellung.ShopId
                 */

                payment.Success = true;
            }
            return payments;
        }

        public List<Storno> SetStorno(List<Storno> cancellations)
        {
            foreach (Storno cancellation in cancellations)
            {
                /* set order cancellation to your marketplace:
                 * if it fails set Success to false
                 * else set Success to true
                 * you can identify the order by cancellation.Bestellung.ShopId
                 */

                cancellation.Success = true;
            }
            return cancellations;
        }

        public List<Storno> GetStorno(DateTime startdate)
        {
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