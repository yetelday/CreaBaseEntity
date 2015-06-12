<<<<<<< HEAD
﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using BricaChocBO;

namespace BricaChocDAL.ConfigurationEntity
{
    internal class TvaConfiguration : EntityTypeConfiguration<Tva>
    {
        public TvaConfiguration() : base()
        {
            HasKey(p => p.Code);
            Property(p => p.Code).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Taux).IsOptional().HasColumnType("decimal").HasPrecision(18,0);
            ToTable("Tva");
        }
    }
=======
﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using BricaChocBO;

namespace BricaChocDAL.ConfigurationEntity
{
    internal class TvaConfiguration : EntityTypeConfiguration<Tva>
    {
        public TvaConfiguration() : base()
        {
            HasKey(p => p.Code);
            Property(p => p.Code).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Taux).IsOptional().HasColumnType("decimal").HasPrecision(18,0);
            ToTable("Tva");
        }
    }
>>>>>>> 945bc79283f0484afc78d262d829c38d5a4beb75
}