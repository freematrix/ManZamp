using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManLib.Business
{
    public enum typeProg : ushort
    {
        apache = 0,
        mariadb = 1,
        generic_program = 2,
        editor = 3,
        apache_and_mariadb = 4
    }

    public enum typeStartorKill : ushort
    {
        start = 0,
        kill = 1
    }
}
