<<<<<<< HEAD
﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using BricaChocBO;

namespace BricaChocDAL.ConfigurationEntity
{
    internal class FamilleConfiguration : EntityTypeConfiguration<Famille>
    {
        public FamilleConfiguration() : base()
        {
            HasKey(p => p.CodeFamille);

            Property(p => p.CodeFamille).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.LibelleFamille).IsOptional().HasColumnType("varchar").HasMaxLength(30);

            HasRequired(p => p.Tva1).WithMany().HasForeignKey(p => p.Tva1);
            ToTable("Famille");
        }
    }
=======
﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using BricaChocBO;

namespace BricaChocDAL.ConfigurationEntity
{
    internal class FamilleConfiguration : EntityTypeConfiguration<Famille>
    {
        public FamilleConfiguration() : base()
        {
            HasKey(p => p.CodeFamille);

            Property(p => p.CodeFamille).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.LibelleFamille).IsOptional().HasColumnType("varchar").HasMaxLength(30);

            HasRequired(p => p.Tva1).WithMany().HasForeignKey(p => p.Tva1);
            ToTable("Famille");
        }
    }
>>>>>>> 945bc79283f0484afc78d262d829c38d5a4beb75
}