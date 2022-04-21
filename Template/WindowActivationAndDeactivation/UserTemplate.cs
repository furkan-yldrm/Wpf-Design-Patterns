using System;
using System.Collections.Generic;
using System.Text;

namespace WindowActivationAndDeactivation
{
    abstract class UserTemplate
    {

       public string User()
        {
            return "User : " + WhoUse();
        }
        public string Age()
        {
            return "Age : " + UserAge();
        }
        public string Job()
        {
            return "Job : " + UserJob();
        }
        public string UsingTemplate()
        {
            return User() + "\n" + Age() + "\n" + Job();
        }

        public abstract string UserJob();
        public abstract string WhoUse();
        public abstract int UserAge();

    }
}
