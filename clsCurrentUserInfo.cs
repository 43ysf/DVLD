using DVLD_Business.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD
{
    public static  class clsCurrentUserInfo
    {
        public static clsUser User { get; set; }
        public static int CurrentUserID { set; get; }
    }
}
