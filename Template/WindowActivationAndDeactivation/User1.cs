using System;
using System.Collections.Generic;
using System.Text;

namespace WindowActivationAndDeactivation
{
    class User1 : UserTemplate
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
            return "Furkan";
        }
    }
}
