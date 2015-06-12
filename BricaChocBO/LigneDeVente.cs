// File:    LigneDeVente.cs
// Author:  Elisabeth
// Created: samedi 16 mai 2015 16:34:44
// Purpose: Definition of Class LigneDeVente

using System;

namespace BricaChocBO
{
   public class LigneDeVente
   {
        public int Qte { get; set; }
        public decimal PrixUttc { get; set; }
        public string DescriptionProduit { get; set; }
        public Produit LeProduitReference { get; set; }
        public decimal SousTotalHT { get { return LeProduitReference.PrixHt*Qte; } }
        public decimal SousTotalTTC { get { return LeProduitReference.PrixHt*Qte*LeProduitReference.Famille.TxTva; } }
        public int CodeFamille { get; set; }
        public string Cpu { get; set; }

        public LigneDeVente() { }
        public LigneDeVente(int qte, decimal prixUttc, string descriptionProduit, Produit leProduitReference)
       {
           Qte = qte;
           PrixUttc = prixUttc;
           DescriptionProduit = descriptionProduit;
           LeProduitReference = leProduitReference;
       }


   }
}