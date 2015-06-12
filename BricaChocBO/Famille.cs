<<<<<<< HEAD
// File:    Famille.cs
// Author:  Elisabeth
// Created: mercredi 22 avril 2015 00:26:51
// Purpose: Definition of Class Famille

using System;

namespace BricaChocBO
{
   public class Famille
   {
        public Famille()
        {
        }

        public Famille(int codeFamille, string libelleFamille, Tva tva)
       {
           this.CodeFamille = codeFamille;
           this.LibelleFamille = libelleFamille;
           this.Tva1 = tva;
       }

       public int CodeFamille { get; set; }

       public string LibelleFamille { get; set; }

       public Tva Tva1 { get; set; }
        public decimal TxTva { get { return Tva1.Taux; } }
   
   }
=======
// File:    Famille.cs
// Author:  Elisabeth
// Created: mercredi 22 avril 2015 00:26:51
// Purpose: Definition of Class Famille

using System;

namespace BricaChocBO
{
   public class Famille
   {
        public Famille()
        {
        }

        public Famille(int codeFamille, string libelleFamille, Tva tva)
       {
           this.CodeFamille = codeFamille;
           this.LibelleFamille = libelleFamille;
           this.Tva1 = tva;
       }

       public int CodeFamille { get; set; }

       public string LibelleFamille { get; set; }

       public Tva Tva1 { get; set; }
        public decimal TxTva { get { return Tva1.Taux; } }
   
   }
>>>>>>> 945bc79283f0484afc78d262d829c38d5a4beb75
}