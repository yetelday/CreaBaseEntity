<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BricaChocDAL.ConfigurationEntity;

namespace CreationBase
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new BricaChocInitializer());
            using (var context = new BricaChocContext())
            {
                context.Database.Initialize(false);
            }
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
using BricaChocDAL.ConfigurationEntity;

namespace CreationBase
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new BricaChocInitializer());
            using (var context = new BricaChocContext())
            {
                context.Database.Initialize(false);
            }
        }
    }
}
>>>>>>> 945bc79283f0484afc78d262d829c38d5a4beb75
