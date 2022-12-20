using Abstraction_Interface_Class.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_Interface_Class.Services
{

    internal class AccountService : IAccountService, ICommonService

    {
        public string FullData()
        {
            throw new NotImplementedException();
        }
    }
}
