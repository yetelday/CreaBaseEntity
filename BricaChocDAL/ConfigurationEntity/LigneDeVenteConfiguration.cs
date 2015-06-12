using System.Data.Entity.ModelConfiguration;
using BricaChocBO;

namespace BricaChocDAL.ConfigurationEntity
{
    internal class LigneDeVenteConfiguration : EntityTypeConfiguration<LigneDeVente>
    {
        public LigneDeVenteConfiguration()
        {
            HasKey(p => new { p., p.IdFamille });
        }
    }
}