// File:    Tva.cs
// Author:  Elisabeth
// Created: mercredi 22 avril 2015 00:26:51
// Purpose: Definition of Class Tva

using System;

namespace BricaChocBO
{
   public class Tva
   {
        public Tva()
        {
        }

        public Tva(int code, decimal taux)
       {
           Code = code;
           Taux = taux;
       }

       public int Code { get; set; }

       public decimal Taux { get; set; }
   }
}