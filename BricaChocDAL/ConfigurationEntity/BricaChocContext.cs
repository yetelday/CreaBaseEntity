<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using BricaChocBO;

namespace BricaChocDAL.ConfigurationEntity
{
    public class BricaChocContext : DbContext
    {
        public BricaChocContext(): base("name=BricaChocCS") { }

        #region DbSet
        public DbSet<Famille> Familles { get; set; }
        public DbSet<LigneDeVente> LigneDeVentes { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Caissier> Caissiers { get; set; }
        public DbSet<Produit> Produits { get; set; }
        public DbSet<Tva> Tvas { get; set; }
        public DbSet<Vente> Ventes { get; set; }
        public DbSet<Paiement> Paiements { get; set; } 
        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add(new FamilleConfiguration());
            modelBuilder.Configurations.Add(new LigneDeVenteConfiguration());
            modelBuilder.Configurations.Add(new ManagerConfiguration());
            modelBuilder.Configurations.Add(new CaissierConfiguration());
            modelBuilder.Configurations.Add(new ProduitConfiguration());
            modelBuilder.Configurations.Add(new TvaConfiguration());
            modelBuilder.Configurations.Add(new VenteConfiguration());
            modelBuilder.Configurations.Add(new PaiementConfiguration());
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using BricaChocBO;

namespace BricaChocDAL.ConfigurationEntity
{
    public class BricaChocContext : DbContext
    {
        public BricaChocContext(): base("name=BricaChocCS") { }

        #region DbSet
        public DbSet<Famille> Familles { get; set; }
        public DbSet<LigneDeVente> LigneDeVentes { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Caissier> Caissiers { get; set; }
        public DbSet<Produit> Produits { get; set; }
        public DbSet<Tva> Tvas { get; set; }
        public DbSet<Vente> Ventes { get; set; }
        public DbSet<Paiement> Paiements { get; set; } 
        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add(new FamilleConfiguration());
            modelBuilder.Configurations.Add(new LigneDeVenteConfiguration());
            modelBuilder.Configurations.Add(new ManagerConfiguration());
            modelBuilder.Configurations.Add(new CaissierConfiguration());
            modelBuilder.Configurations.Add(new ProduitConfiguration());
            modelBuilder.Configurations.Add(new TvaConfiguration());
            modelBuilder.Configurations.Add(new VenteConfiguration());
            modelBuilder.Configurations.Add(new PaiementConfiguration());
        }
    }
}
>>>>>>> 945bc79283f0484afc78d262d829c38d5a4beb75
