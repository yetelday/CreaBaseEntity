<<<<<<< HEAD
﻿using System.Data.Entity.ModelConfiguration;
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
=======
﻿using System.Data.Entity.ModelConfiguration;

namespace BricaChocDAL.ConfigurationEntity
{
    internal class LigneDeVenteConfiguration : EntityTypeConfiguration<object>
    {
        public LigneDeVenteConfiguration()
        {
        }
    }
>>>>>>> 945bc79283f0484afc78d262d829c38d5a4beb75
}