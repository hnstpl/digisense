using AdminPortal.Mvc.DataProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPortal.Mvc.Services
{
    public class UserService : IUserService
    {
        private readonly dev_encrypted_generalcustomerappContext _context;

        public UserService(dev_encrypted_generalcustomerappContext entityContext)
        {
            _context = entityContext;
        }

        public TblAdminusers GetUserByCred(string username, string password)
        {
            return _context.TblAdminusers.SingleOrDefault(x => x.Username == username && string.Equals(x.Password, password, StringComparison.OrdinalIgnoreCase));
        }

        public MstUserrole GetRoleByRoleID(int ID)
        {
            return _context.MstUserrole.SingleOrDefault(x => x.Id == ID);
        }
    }
}
