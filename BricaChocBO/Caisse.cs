<<<<<<< HEAD
// File:    Caisse.cs
// Author:  Elisabeth
// Created: samedi 16 mai 2015 16:33:18
// Purpose: Definition of Class Caisse

using System;

namespace BricaChocBO
{
   public class Caisse
   {
       public Caisse(string nomDuMagasin, decimal fondDeCaissse, string messageClient, Vente venteEnAttente, Vente venteEnCours, Catalogue catalogue)
       {
           this.NomDuMagasin = nomDuMagasin;
           this.FondDeCaissse = fondDeCaissse;
           this.MessageClient = messageClient;
           this.VenteEnAttente = venteEnAttente;
           this.VenteEnCours = venteEnCours;
           this.Catalogue = catalogue;
       }

       public Caisse()
       {
           throw new NotImplementedException();
       }

       public string NomDuMagasin { get; set; }

       public decimal FondDeCaissse { get; set; }

       public string MessageClient { get; set; }

       public Vente VenteEnAttente { get; set; }

       public Vente VenteEnCours { get; set; }

       public Catalogue Catalogue { get; set; }
   }
=======
// File:    Caisse.cs
// Author:  Elisabeth
// Created: samedi 16 mai 2015 16:33:18
// Purpose: Definition of Class Caisse

using System;

namespace BricaChocBO
{
   public class Caisse
   {
       public Caisse(string nomDuMagasin, decimal fondDeCaissse, string messageClient, Vente venteEnAttente, Vente venteEnCours, Catalogue catalogue)
       {
           this.NomDuMagasin = nomDuMagasin;
           this.FondDeCaissse = fondDeCaissse;
           this.MessageClient = messageClient;
           this.VenteEnAttente = venteEnAttente;
           this.VenteEnCours = venteEnCours;
           this.Catalogue = catalogue;
       }

       public Caisse()
       {
           throw new NotImplementedException();
       }

       public string NomDuMagasin { get; set; }

       public decimal FondDeCaissse { get; set; }

       public string MessageClient { get; set; }

       public Vente VenteEnAttente { get; set; }

       public Vente VenteEnCours { get; set; }

       public Catalogue Catalogue { get; set; }
   }
>>>>>>> 945bc79283f0484afc78d262d829c38d5a4beb75
}