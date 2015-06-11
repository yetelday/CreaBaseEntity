// File:    Produit.cs
// Author:  Elisabeth
// Created: samedi 16 mai 2015 16:33:47
// Purpose: Definition of Class Produit

using System;

namespace BricaChocBO
{
   public class Produit
   {
        public string Cpu { get; set; }

        public string Description { get; set; }

        public decimal PrixHt { get; set; }

        public bool Generic { get; set; }

        public Famille Famille { get; set; }

        public Produit(string cpu, string description, decimal prixHt, char generic, Famille famille)
       {
           Cpu = cpu;
           Description = description;
           PrixHt = prixHt;
           Generic = generic;
           Famille = famille;
       }

        public Produit()
        {
        }

        protected bool Equals(Produit other)
       {
           return string.Equals(Cpu, other.Cpu);
       }

       public override bool Equals(object obj)
       {
           if (ReferenceEquals(null, obj)) return false;
           if (ReferenceEquals(this, obj)) return true;
           if (obj.GetType() != this.GetType()) return false;
           return Equals((Produit) obj);
       }

       public override int GetHashCode()
       {
           return Cpu?.GetHashCode() ?? 0;
       }
   }
}