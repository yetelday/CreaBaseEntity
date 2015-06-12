using System.Data.Entity.ModelConfiguration;
using BricaChocBO;

namespace BricaChocDAL.ConfigurationEntity
{
    internal class ProduitConfiguration : EntityTypeConfiguration<Produit>
    {
        public ProduitConfiguration() : base()
        {
            HasKey(p => new {p.Cpu, p.IdFamille});

            Property(p => p.Cpu).HasColumnType("varchar").HasMaxLength(30);
            Property(p => p.Description).HasColumnType("varchar").HasMaxLength(30).IsOptional();
            Property(p => p.PrixHt).HasColumnType("decimal").HasPrecision(18, 0).IsOptional();
            Property(p => p.Generic).HasColumnType("char").IsOptional();

            HasRequired(p => p.Famille).WithMany().HasForeignKey(p => p.IdFamille);

            ToTable("Produit");
        }
    }
}