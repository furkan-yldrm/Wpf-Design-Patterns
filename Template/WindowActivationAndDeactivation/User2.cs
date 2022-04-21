using System;
using System.Collections.Generic;
using System.Text;

namespace WindowActivationAndDeactivation
{
    class User2 : UserTemplate
    {
        public override int UserAge()
        {
            return 21;
        }

        public override string UserJob()
        {
            return "Student";
        }

        public override string WhoUse()
        {
            return "Halil";
        }
    }
}
