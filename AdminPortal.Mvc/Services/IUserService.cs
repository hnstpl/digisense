using AdminPortal.Mvc.DataProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPortal.Mvc.Services
{
    public interface IUserService
    {
        TblAdminusers GetUserByCred(string usename, string password);

        MstUserrole GetRoleByRoleID(int ID);
    }
}
