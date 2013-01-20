using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ych.Model;

namespace Ych.Interface
{
    public interface IAccount
    {
        /// <summary>
        /// Create Account
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        bool CreateAccount(Account account);
    }
}
