namespace OnlineShop.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using OnlineShop.Models; 

    internal sealed class Configuration : DbMigrationsConfiguration<OnlineShop.DataAccess.DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(OnlineShop.DataAccess.DatabaseContext context)
        {
            context.Products.AddOrUpdate(new Product { Name = "Lenovo G70-70 43,9 cm (17,3 Zoll HD+ TN) Notebook (Intel Pentium 3558U, 1,7GHz, 4 GB RAM, 500 GB HDD, Intel HD 4400, kein Betriebssystem) schwarz", Description = @"<ul> <li><span>Prozessor: Intel Pentium N3558U Prozessor 1,7 GHz, Intel HD Graphics, kein Betriebssystem</span></li><li><span> Besonderheiten: 4 GB DDR3-RAM, 500 GB Festplatte, DVD-Supermulti-Laufwerk, Speicherkartenleser 4-in-1</span></li><li><span> 1x HDMI, 1x USB 3.0, 2x USB 2.0, WLAN 801.11 b/g/n, Bluetooth 4.0</span></li><li><span> Herstellergarantie: 12 Monate bei Verkauf und Versand durch Amazon. Bei Verkauf und Versand durch einen Drittanbieter gelten die Angaben des jeweiligen Verk�ufers</span></li><li><span> Lieferumfang: Lenovo G70-70, 43,9 cm (17,3 Zoll) Notebook Schwarz, Akku, Netzteil, Dokumentation</span></li></ul>", Price = 281.32M, ProductImage = "/Content/Images/41A4Ya4DYIL._AA160_.jpg", StockCount = 587, Created=DateTime.Now });
            context.Products.AddOrUpdate(new Product { Name = "Asus F205TA-FD0066TS 29,5 cm (11,6 Zoll) Notebook (Intel Atom Z3735F, 2GB RAM, 32GB eMMC, HD Graphic, Win 10 Home) gold", Description = @"<ul> <li><span>Prozessor: Intel Pentium N3558U Prozessor 1,7 GHz, Intel HD Graphics, kein Betriebssystem</span></li><li><span> Besonderheiten: 4 GB DDR3-RAM, 500 GB Festplatte, DVD-Supermulti-Laufwerk, Speicherkartenleser 4-in-1</span></li><li><span> 1x HDMI, 1x USB 3.0, 2x USB 2.0, WLAN 801.11 b/g/n, Bluetooth 4.0</span></li><li><span> Herstellergarantie: 12 Monate bei Verkauf und Versand durch Amazon. Bei Verkauf und Versand durch einen Drittanbieter gelten die Angaben des jeweiligen Verk�ufers</span></li><li><span> Lieferumfang: Lenovo G70-70, 43,9 cm (17,3 Zoll) Notebook Schwarz, Akku, Netzteil, Dokumentation</span></li></ul>", Price = 229.00M, ProductImage = "/Content/Images/513FFHbObmL._AA160_.jpg", StockCount = 25, Created = DateTime.Now });
            context.Products.AddOrUpdate(new Product { Name = "Asus F205TA-BING-FD0035BS 29,46 cm (11,6 Zoll) Notebook (Intel Atom Z3735F, 1,3GHz, 2GB RAM, 32GB SSD, Intel HDGrafik, Win 8) gold", Description = @"<ul> <li><span>Prozessor: Intel Pentium N3558U Prozessor 1,7 GHz, Intel HD Graphics, kein Betriebssystem</span></li><li><span> Besonderheiten: 4 GB DDR3-RAM, 500 GB Festplatte, DVD-Supermulti-Laufwerk, Speicherkartenleser 4-in-1</span></li><li><span> 1x HDMI, 1x USB 3.0, 2x USB 2.0, WLAN 801.11 b/g/n, Bluetooth 4.0</span></li><li><span> Herstellergarantie: 12 Monate bei Verkauf und Versand durch Amazon. Bei Verkauf und Versand durch einen Drittanbieter gelten die Angaben des jeweiligen Verk�ufers</span></li><li><span> Lieferumfang: Lenovo G70-70, 43,9 cm (17,3 Zoll) Notebook Schwarz, Akku, Netzteil, Dokumentation</span></li></ul>", Price = 222.62M, ProductImage = "/Content/Images/51q7qBKuREL._AA160_.jpg", StockCount = 99, Created = DateTime.Now });
            context.Products.AddOrUpdate(new Product { Name = "Apple MacBook MB061 33,8 cm (13,3 Zoll) Notebook wei� (Intel Core 2 Duo 2,0GHz, 1GB RAM, 80GB HDD, DVD-ROM/CD-RW)", Description = @"<ul> <li><span>Prozessor: Intel Pentium N3558U Prozessor 1,7 GHz, Intel HD Graphics, kein Betriebssystem</span></li><li><span> Besonderheiten: 4 GB DDR3-RAM, 500 GB Festplatte, DVD-Supermulti-Laufwerk, Speicherkartenleser 4-in-1</span></li><li><span> 1x HDMI, 1x USB 3.0, 2x USB 2.0, WLAN 801.11 b/g/n, Bluetooth 4.0</span></li><li><span> Herstellergarantie: 12 Monate bei Verkauf und Versand durch Amazon. Bei Verkauf und Versand durch einen Drittanbieter gelten die Angaben des jeweiligen Verk�ufers</span></li><li><span> Lieferumfang: Lenovo G70-70, 43,9 cm (17,3 Zoll) Notebook Schwarz, Akku, Netzteil, Dokumentation</span></li></ul>", Price = 223.00M, ProductImage = "/Content/Images/31WEFAQ4WWL._AA160_.jpg", StockCount = 5, Created = DateTime.Now });
            context.Products.AddOrUpdate(new Product { Name = "HP EliteBook 2540p 30,7cm (12,1 Zoll) Notebook (Intel Core i7 640LM, 2,1GHz, 4GB RAM, 160GB HDD, Intel HD, Windows 7 (Zertifiziert und General�berholt)", Description = @"<ul> <li><span>Prozessor: Intel Pentium N3558U Prozessor 1,7 GHz, Intel HD Graphics, kein Betriebssystem</span></li><li><span> Besonderheiten: 4 GB DDR3-RAM, 500 GB Festplatte, DVD-Supermulti-Laufwerk, Speicherkartenleser 4-in-1</span></li><li><span> 1x HDMI, 1x USB 3.0, 2x USB 2.0, WLAN 801.11 b/g/n, Bluetooth 4.0</span></li><li><span> Herstellergarantie: 12 Monate bei Verkauf und Versand durch Amazon. Bei Verkauf und Versand durch einen Drittanbieter gelten die Angaben des jeweiligen Verk�ufers</span></li><li><span> Lieferumfang: Lenovo G70-70, 43,9 cm (17,3 Zoll) Notebook Schwarz, Akku, Netzteil, Dokumentation</span></li></ul>", Price = 219.90M, ProductImage = "/Content/Images/41MgFm97iTL._AA160_.jpg", StockCount = 1, Created = DateTime.Now });
            context.Products.AddOrUpdate(new Product { Name = "Asus F551MAV-BING-SX1007B 39,6 cm (15,6 Zoll) Notebook (Intel Celeron N2840, 2,58GHz, 4GB RAM, 500GB HDD, Intel HD, DVD, Win 8) wei�", Description = @"<ul> <li><span>Prozessor: Intel Pentium N3558U Prozessor 1,7 GHz, Intel HD Graphics, kein Betriebssystem</span></li><li><span> Besonderheiten: 4 GB DDR3-RAM, 500 GB Festplatte, DVD-Supermulti-Laufwerk, Speicherkartenleser 4-in-1</span></li><li><span> 1x HDMI, 1x USB 3.0, 2x USB 2.0, WLAN 801.11 b/g/n, Bluetooth 4.0</span></li><li><span> Herstellergarantie: 12 Monate bei Verkauf und Versand durch Amazon. Bei Verkauf und Versand durch einen Drittanbieter gelten die Angaben des jeweiligen Verk�ufers</span></li><li><span> Lieferumfang: Lenovo G70-70, 43,9 cm (17,3 Zoll) Notebook Schwarz, Akku, Netzteil, Dokumentation</span></li></ul>", Price = 219.19M, ProductImage = "/Content/Images/518AHnbF2-L._AA160_.jpg", StockCount = 15, Created = DateTime.Now });
            context.Products.AddOrUpdate(new Product { Name = "Fujitsu LIFEBOOK A512 NG 39,6 cm (15,6 Zoll)Anti-Glare-HD-LCD im 16:9-Breitbildformat Notebook (Intel Pentium 2020M, 2,4GHz, 4GB RAM, 500GB HDD, DVD, Win 7 HP) schwarz", Description = @"<ul> <li><span>Prozessor: Intel Pentium N3558U Prozessor 1,7 GHz, Intel HD Graphics, kein Betriebssystem</span></li><li><span> Besonderheiten: 4 GB DDR3-RAM, 500 GB Festplatte, DVD-Supermulti-Laufwerk, Speicherkartenleser 4-in-1</span></li><li><span> 1x HDMI, 1x USB 3.0, 2x USB 2.0, WLAN 801.11 b/g/n, Bluetooth 4.0</span></li><li><span> Herstellergarantie: 12 Monate bei Verkauf und Versand durch Amazon. Bei Verkauf und Versand durch einen Drittanbieter gelten die Angaben des jeweiligen Verk�ufers</span></li><li><span> Lieferumfang: Lenovo G70-70, 43,9 cm (17,3 Zoll) Notebook Schwarz, Akku, Netzteil, Dokumentation</span></li></ul>", Price = 299.00M, ProductImage = "/Content/Images/41Tb2pvqZL._AA160_.jpg", StockCount = 5, Created = DateTime.Now });
            context.Products.AddOrUpdate(new Product { Name = "Lenovo IdeaPad U330P 33,7 cm (13,3 Zoll HD) Notebook (Intel Core i5 4210U, 2,7GHz, 4GB RAM, Hybrid 500GB SSHD(8GB), Intel HD Graphics 4400, kein Betriebssystem) grau", Description = @"<ul> <li><span>Prozessor: Intel Pentium N3558U Prozessor 1,7 GHz, Intel HD Graphics, kein Betriebssystem</span></li><li><span> Besonderheiten: 4 GB DDR3-RAM, 500 GB Festplatte, DVD-Supermulti-Laufwerk, Speicherkartenleser 4-in-1</span></li><li><span> 1x HDMI, 1x USB 3.0, 2x USB 2.0, WLAN 801.11 b/g/n, Bluetooth 4.0</span></li><li><span> Herstellergarantie: 12 Monate bei Verkauf und Versand durch Amazon. Bei Verkauf und Versand durch einen Drittanbieter gelten die Angaben des jeweiligen Verk�ufers</span></li><li><span> Lieferumfang: Lenovo G70-70, 43,9 cm (17,3 Zoll) Notebook Schwarz, Akku, Netzteil, Dokumentation</span></li></ul>", Price = 499.00M, ProductImage = "/Content/Images/41R0HxWERWL._AA160_.jpg", StockCount = 11, Created = DateTime.Now });
            context.Products.AddOrUpdate(new Product { Name = "Medion NB S2217 29,6 cm (11,6 Zoll) Notebook (Intel Atom Z3735F QuadCore, Full-HD, 2GB RAM, 64 GB SSD, Intel HD Graphics, Win 10) silber", Description = @"<ul> <li><span>Prozessor: Intel Pentium N3558U Prozessor 1,7 GHz, Intel HD Graphics, kein Betriebssystem</span></li><li><span> Besonderheiten: 4 GB DDR3-RAM, 500 GB Festplatte, DVD-Supermulti-Laufwerk, Speicherkartenleser 4-in-1</span></li><li><span> 1x HDMI, 1x USB 3.0, 2x USB 2.0, WLAN 801.11 b/g/n, Bluetooth 4.0</span></li><li><span> Herstellergarantie: 12 Monate bei Verkauf und Versand durch Amazon. Bei Verkauf und Versand durch einen Drittanbieter gelten die Angaben des jeweiligen Verk�ufers</span></li><li><span> Lieferumfang: Lenovo G70-70, 43,9 cm (17,3 Zoll) Notebook Schwarz, Akku, Netzteil, Dokumentation</span></li></ul>", Price = 289.00M, ProductImage = "/Content/Images/41qPAFtSFcL._AA160_.jpg", StockCount = 17, Created = DateTime.Now });
            context.Products.AddOrUpdate(new Product { Name = "ASUS F751M (17,3 Zoll) Notebook (Intel N2940 Quad Core 4x2.25 GHz, 8GB RAM, 1000GB S-ATA HDD, Intel HD Graphic, HDMI, Webcam, USB 3.0, WLAN, DVD-Brenner, Windows 7 Professional 64 Bit) #4893", Description = @"<ul> <li><span>Prozessor: Intel Pentium N3558U Prozessor 1,7 GHz, Intel HD Graphics, kein Betriebssystem</span></li><li><span> Besonderheiten: 4 GB DDR3-RAM, 500 GB Festplatte, DVD-Supermulti-Laufwerk, Speicherkartenleser 4-in-1</span></li><li><span> 1x HDMI, 1x USB 3.0, 2x USB 2.0, WLAN 801.11 b/g/n, Bluetooth 4.0</span></li><li><span> Herstellergarantie: 12 Monate bei Verkauf und Versand durch Amazon. Bei Verkauf und Versand durch einen Drittanbieter gelten die Angaben des jeweiligen Verk�ufers</span></li><li><span> Lieferumfang: Lenovo G70-70, 43,9 cm (17,3 Zoll) Notebook Schwarz, Akku, Netzteil, Dokumentation</span></li></ul>", Price = 529.00M, ProductImage = "/Content/Images/518zqjss9VL._AA160_.jpg", StockCount = 3, Created = DateTime.Now });
        }
    }
}