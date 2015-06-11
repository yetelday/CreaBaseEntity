using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using BricaChocBO;

namespace BricaChocDAL.ConfigurationEntity
{
    internal class PaiementConfiguration : EntityTypeConfiguration<Paiement>
    {
        public PaiementConfiguration() : base()
        {
            HasKey(p => new {p.IdVente, p.IdPaiement});
            Property(p => p.IdPaiement).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Montant).IsOptional().HasColumnType("decimal").HasPrecision(18, 0);
            ToTable("Paiement");
        }
    }
}