using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.UserExceptions
{
    public class BookingException:ApplicationException
    {
        public BookingException(string msg)
            : base(msg) { }
    }
}
