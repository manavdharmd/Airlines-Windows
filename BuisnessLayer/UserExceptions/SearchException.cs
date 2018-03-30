using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.UserExceptions
{
    class SearchException:ApplicationException
    {
        public SearchException(string msg)
            : base(msg) { }
    }
}
