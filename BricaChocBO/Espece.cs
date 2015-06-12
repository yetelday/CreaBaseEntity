// File:    Espece.cs
// Author:  Elisabeth
// Created: mercredi 22 avril 2015 00:26:51
// Purpose: Definition of Class Espece

using System;

namespace BricaChocBO
{
   public class Espece : Paiement
   {
       public Espece(decimal rendu) : base()
       {
           Rendu = rendu;
       }

       public decimal Rendu { get; set; }
   }
}