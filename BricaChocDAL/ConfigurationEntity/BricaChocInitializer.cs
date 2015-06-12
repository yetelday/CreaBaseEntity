<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BricaChocBO;

namespace BricaChocDAL.ConfigurationEntity
{
    public class BricaChocInitializer : DropCreateDatabaseAlways<BricaChocContext>
    {
        protected override void Seed(BricaChocContext db)
        {
            var laCaisse = new Caisse();
            Catalogue cat = new Catalogue();

            List<Tva> lstTva = new List<Tva>()
            {
              new Tva()
                {
                   Code=1,
                   Taux=0.206M
                },
              new Tva()
                {
                    Code=2,
                    Taux=0.10M
                },
              new Tva()
                {
                    Code=3,
                    Taux=0.55M
                }
          };

            cat.Familles = new List<Famille>()
            {
            new Famille()
            {
                CodeFamille=1,
                LibelleFamille="Alimentaire",
                Tva1 = lstTva[0]
            },
            new Famille()
            {
                CodeFamille=2,
                LibelleFamille="Boissons sans alcool",
                Tva1 = lstTva[0]
            },
             new Famille()
            {
               CodeFamille=3,
               LibelleFamille="Boissons alcoolisées",
               Tva1 = lstTva[0]
            }
        };

            cat.Produits = new List<Produit>()
            {
                new Produit()
                {
                    Cpu = "Art01",
                    Description = "Plaquette de beurre",
                    PrixHt = 10,
                    Generic=false,
                    Famille= cat.Familles.Where(p=> p.CodeFamille == 1).Single(),
                },
                new Produit()
                {
                    Cpu = "Art02",
                    Description = "Coca",
                    PrixHt = 11,
                    Generic=false,
                    Famille= cat.Familles.Where(p=> p.CodeFamille == 2).Single(),
                },
                 new Produit()
                {
                    Cpu = "Art03",
                    Description = "Finger x 24",
                    PrixHt = 5,
                    Generic=false,
                    Famille= cat.Familles.Where(p=> p.CodeFamille == 1).Single(),
                },
        };
          
        }
    }
    }

=======
﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BricaChocBO;

namespace BricaChocDAL.ConfigurationEntity
{
    public class BricaChocInitializer : DropCreateDatabaseAlways<BricaChocContext>
    {
        protected override void Seed(BricaChocContext db)
        {
            var laCaisse = new Caisse();
            Catalogue cat = new Catalogue();

            List<Tva> lstTva = new List<Tva>()
            {
              new Tva()
                {
                   Code=1,
                   Taux=0.206M
                },
              new Tva()
                {
                    Code=2,
                    Taux=0.10M
                },
              new Tva()
                {
                    Code=3,
                    Taux=0.55M
                }
          };

            cat.Familles = new List<Famille>()
            {
            new Famille()
            {
                CodeFamille=1,
                LibelleFamille="Alimentaire",
                Tva1 = lstTva[0]
            },
            new Famille()
            {
                CodeFamille=2,
                LibelleFamille="Boissons sans alcool",
                Tva1 = lstTva[0]
            },
             new Famille()
            {
               CodeFamille=3,
               LibelleFamille="Boissons alcoolisées",
               Tva1 = lstTva[0]
            }
        };

            cat.Produits = new List<Produit>()
            {
                new Produit()
                {
                    Cpu = "Art01",
                    Description = "Plaquette de beurre",
                    PrixHt = 10,
                    Generic=false,
                    Famille= cat.Familles.Where(p=> p.CodeFamille == 1).Single(),
                },
                new Produit()
                {
                    Cpu = "Art02",
                    Description = "Coca",
                    PrixHt = 11,
                    Generic=false,
                    Famille= cat.Familles.Where(p=> p.CodeFamille == 2).Single(),
                },
                 new Produit()
                {
                    Cpu = "Art03",
                    Description = "Finger x 24",
                    PrixHt = 5,
                    Generic=false,
                    Famille= cat.Familles.Where(p=> p.CodeFamille == 1).Single(),
                },
        };
          
        }
    }
    }

>>>>>>> 945bc79283f0484afc78d262d829c38d5a4beb75
