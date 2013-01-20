using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ych.Base;
using Ych.Interface;
using Ych.Model;

namespace Ych.Service
{
    public class AccountService : IAccount
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public bool CreateAccount(Account account)
        {
            int x = 0;
            var collection = MongoDb.Instance.GetCollection<Account>();
            var result = collection.Insert(account);
            return result.Ok;
        }
    }
}
