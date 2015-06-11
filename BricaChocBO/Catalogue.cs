// File:    Catalogue.cs
// Author:  Elisabeth
// Created: samedi 16 mai 2015 16:33:28
// Purpose: Definition of Class Catalogue

using System;

namespace BricaChocBO
{
   public class Catalogue
   {
      private System.Collections.Generic.List<Produit> produits;
      
      /// <summary>
      /// Property for collection of Produit
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.Generic.List<Produit> Produits
      {
         get
         {
            if (produits == null)
               produits = new System.Collections.Generic.List<Produit>();
            return produits;
         }
         set
         {
            RemoveAllProduits();
            if (value != null)
            {
               foreach (Produit oProduit in value)
                  AddProduits(oProduit);
            }
         }
      }
      
      /// <summary>
      /// Add a new Produit in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddProduits(Produit newProduit)
      {
         if (newProduit == null)
            return;
         if (this.produits == null)
            this.produits = new System.Collections.Generic.List<Produit>();
         if (!this.produits.Contains(newProduit))
            this.produits.Add(newProduit);
      }
      
      /// <summary>
      /// Remove an existing Produit from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveProduits(Produit oldProduit)
      {
         if (oldProduit == null)
            return;
         if (this.produits != null)
            if (this.produits.Contains(oldProduit))
               this.produits.Remove(oldProduit);
      }
      
      /// <summary>
      /// Remove all instances of Produit from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllProduits()
      {
         if (produits != null)
            produits.Clear();
      }
      private System.Collections.Generic.List<Famille> familles;
      
      /// <summary>
      /// Property for collection of Famille
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.Generic.List<Famille> Familles
      {
         get
         {
            if (familles == null)
               familles = new System.Collections.Generic.List<Famille>();
            return familles;
         }
         set
         {
            RemoveAllFamilles();
            if (value != null)
            {
               foreach (Famille oFamille in value)
                  AddFamilles(oFamille);
            }
         }
      }
      
      /// <summary>
      /// Add a new Famille in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddFamilles(Famille newFamille)
      {
         if (newFamille == null)
            return;
         if (this.familles == null)
            this.familles = new System.Collections.Generic.List<Famille>();
         if (!this.familles.Contains(newFamille))
            this.familles.Add(newFamille);
      }
      
      /// <summary>
      /// Remove an existing Famille from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveFamilles(Famille oldFamille)
      {
         if (oldFamille == null)
            return;
         if (this.familles != null)
            if (this.familles.Contains(oldFamille))
               this.familles.Remove(oldFamille);
      }
      
      /// <summary>
      /// Remove all instances of Famille from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllFamilles()
      {
         if (familles != null)
            familles.Clear();
      }
   
   }
}