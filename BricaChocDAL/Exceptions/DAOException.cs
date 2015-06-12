<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BricaChocDAL.Exceptions
{
    class DaoException : Exception
    {
        public DaoException() : base()
        {
        }

        public DaoException(string message)
            : base(message)
        {
        }
        public DaoException(string message, System.Exception inner)
            : base(message, inner)
        {
        }

    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BricaChocDAL.Exceptions
{
    class DaoException : Exception
    {
        public DaoException() : base()
        {
        }

        public DaoException(string message)
            : base(message)
        {
        }
        public DaoException(string message, System.Exception inner)
            : base(message, inner)
        {
        }

    }
}
>>>>>>> 945bc79283f0484afc78d262d829c38d5a4beb75
