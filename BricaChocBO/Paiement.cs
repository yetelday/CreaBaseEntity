<<<<<<< HEAD
// File:    Paiement.cs
// Author:  Elisabeth
// Created: samedi 16 mai 2015 16:36:04
// Purpose: Definition of Class Paiement

using System;

namespace BricaChocBO
{
   public abstract class Paiement
   {
        public Paiement()
        {
        }

        protected Paiement(int idVente, int idPaiement, decimal montant)
        {
            IdVente = idVente;
            IdPaiement = idPaiement;
            Montant = montant;
        }

        public int IdVente { get; set; }
        public int IdPaiement { get; set; }

       public decimal Montant { get; set; }
   }
=======
// File:    Paiement.cs
// Author:  Elisabeth
// Created: samedi 16 mai 2015 16:36:04
// Purpose: Definition of Class Paiement

using System;

namespace BricaChocBO
{
   public abstract class Paiement
   {
        public Paiement()
        {
        }

        protected Paiement(int idVente, int idPaiement, decimal montant)
        {
            IdVente = idVente;
            IdPaiement = idPaiement;
            Montant = montant;
        }

        public int IdVente { get; set; }
        public int IdPaiement { get; set; }

       public decimal Montant { get; set; }
   }
>>>>>>> 945bc79283f0484afc78d262d829c38d5a4beb75
}