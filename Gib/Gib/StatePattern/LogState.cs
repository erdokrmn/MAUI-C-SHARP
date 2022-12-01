using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gib.Pattern
{
    public abstract class LogState
    {
        public abstract void LoginOrLogout(Control control);
    }
}
