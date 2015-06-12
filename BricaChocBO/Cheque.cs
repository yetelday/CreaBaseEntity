// File:    Cheque.cs
// Author:  Elisabeth
// Created: mercredi 22 avril 2015 00:26:51
// Purpose: Definition of Class Cheque

using System;

namespace BricaChocBO
{
   public class Cheque : Paiement
   {
       public Cheque(decimal montant) : base(montant)
       {
       }
   }
}