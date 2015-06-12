<<<<<<< HEAD
// File:    Vente.cs
// Author:  Juan Fidel
// Created: samedi 16 mai 2015 16:35:40
// Purpose: Definition of Class Vente

using System;
using System.Collections.Generic;
using System.Linq;

namespace BricaChocBO
{
   public class Vente
   {
        public DateTime Date { get; set; }

        public decimal TotalHt { get; set; }

        public decimal TotalTtc { get; set; }

        public List<Paiement> Paiements { get; set; }

        public List<LigneDeVente> LignesDeVente { get; set; }
        public decimal TotTTC
        {
            get { return LignesDeVente.Sum(x => x.SousTotalTTC); }
        }
        public decimal ResteARegler { get
        {
            return TotTTC - Paiements.Sum(x => x.Montant) + Paiements.OfType<Espece>().Sum(x => x.Rendu);
        } }
        public Vente(DateTime date, decimal totalHt, decimal totalTtc, List<Paiement> paiements, List<LigneDeVente> lignesDeVente)
       {
           Date = date;
           TotalHt = totalHt;
           TotalTtc = totalTtc;
           Paiements = paiements;
           LignesDeVente = lignesDeVente;
       }

       public Vente()
       {
           //var ldvs = new LigneDeVente();
       }

       
   }
=======
// File:    Vente.cs
// Author:  Juan Fidel
// Created: samedi 16 mai 2015 16:35:40
// Purpose: Definition of Class Vente

using System;
using System.Collections.Generic;
using System.Linq;

namespace BricaChocBO
{
   public class Vente
   {
        public DateTime Date { get; set; }

        public decimal TotalHt { get; set; }

        public decimal TotalTtc { get; set; }

        public List<Paiement> Paiements { get; set; }

        public List<LigneDeVente> LignesDeVente { get; set; }
        public decimal TotTTC
        {
            get { return LignesDeVente.Sum(x => x.SousTotalTTC); }
        }
        public decimal ResteARegler { get
        {
            return TotTTC - Paiements.Sum(x => x.Montant) + Paiements.OfType<Espece>().Sum(x => x.Rendu);
        } }
        public Vente(DateTime date, decimal totalHt, decimal totalTtc, List<Paiement> paiements, List<LigneDeVente> lignesDeVente)
       {
           Date = date;
           TotalHt = totalHt;
           TotalTtc = totalTtc;
           Paiements = paiements;
           LignesDeVente = lignesDeVente;
       }

       public Vente()
       {
           //var ldvs = new LigneDeVente();
       }

       
   }
>>>>>>> 945bc79283f0484afc78d262d829c38d5a4beb75
}